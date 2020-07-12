using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace VoenKaffServer
{
    class WordSaver
    {
        object wMissing = Type.Missing;
        object wTrue = true;
        object wFalse = false;
        Word.Document oDoc;

        private Word.Application wordapp;

        Word.Table table;

        int firstEmptyRow = 0;
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            try
            {
                object missing = System.Reflection.Missing.Value;
                if (DGV.Rows.Count != 0)
                {
                    int RowCount = DGV.Rows.Count;
                    int ColumnCount = DGV.Columns.Count;
                    Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];
                    int r = 0;

                    //add rows

                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        for (r = 0; r <= RowCount - 1; r++)
                        {
                            DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                        } //end row loop
                    } //end column loop

                    //if (File.Exists(filename))
                    //{
                    //    wordapp = new Word.Application();
                    //    oDoc = wordapp.Documents.Open2000(filename);
                    //    table = oDoc.Tables[1];
                    //    for (int i = 0; i < table.Rows.Count; i++)
                    //    {
                    //        MessageBox.Show(filename + table.Cell(0, i).Range.Text);
                    //        if (table.Cell(0,i).Range.Text == "")
                    //        {
                                
                    //            firstEmptyRow = i;
                    //        }
                    //    }
                            
                    //}
                    //else
                    //{
                    //    oDoc = new Word.Document();
                    //}

                    oDoc = new Word.Document();

                    //page orintation
                    oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;

                    dynamic oRange = oDoc.Content.Application.Selection.Range;
                    string oTemp = "";
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        for (int c = 0; c <= ColumnCount - 1; c++)
                        {

                            oTemp = oTemp + DataArray[r, c]?.ToString().Replace("\t", "").Replace("\n", "").Replace("\r", "") + "\t";

                        }
                    }
                    //table format
                    oRange.Text = oTemp;

                    object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                    object ApplyBorders = true;
                    object AutoFit = true;
                    object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                    oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                          Type.Missing, Type.Missing, ref ApplyBorders,
                                          Type.Missing, Type.Missing, Type.Missing,
                                          Type.Missing, Type.Missing, Type.Missing,
                                          Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                    oRange.Select();

                    oDoc.Application.Selection.Tables[1].Select();
                    oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                    oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    oDoc.Application.Selection.InsertRowsAbove(1);
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();

                    //header row style
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                    //add header row manually
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                    }


                    //if (!File.Exists(filename))
                    //{
                    //    oDoc.Application.Selection.InsertRowsAbove(1);
                    //    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    //    //header row style
                    //    oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                    //    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                    //    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                    //    //add header row manually
                    //    for (int c = 0; c <= ColumnCount - 1; c++)
                    //    {
                    //        oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                    //    }
                    //}
                    //else
                    //{
                    //    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    //}
                    


                    //table style 
                    //oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    oDoc.Application.Selection.Tables[1].Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    oDoc.Application.Selection.Tables[1].Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

                    

                    //header text
                    foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                    {
                        Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                        headerRange.Text = "Результаты";
                        headerRange.Font.Size = 16;
                        headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    }

                    //save the file
                    oDoc.SaveAs2000(filename);
                    oDoc.Application.Documents[filename].Save();
                    oDoc.Close(ref missing, ref missing, ref missing);
                    //NASSIM LOUCHANI
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
