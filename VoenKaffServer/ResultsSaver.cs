using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoenKaffServer.Wrappers;

namespace VoenKaffServer
{
    public class ResultsSaver
    {
        private readonly DynamicParams _parameters;

        public Boolean testsSaved = true;
        public Boolean studySaved = true;
        public DataGridView _testsTable;
        public DataGridView _studyTable;

        WordSaver ws = new WordSaver();
        SaveFileDialog sfd = new SaveFileDialog();

        Dictionary<string, List<DataGridViewRow>> courseAndRows;
        Dictionary<string, string> listColumns;
        Dictionary<string, List<DataGridViewRow>> docNameAndRows;

        Dictionary<string, List<Result>> dicCourses;
        Dictionary<string, List<DataGridViewRow>> docnameAndResults;
        public string _typeRes1;
        public string _typeRes2;

        public ResultsSaver(DataGridView testsTable, DataGridView studyTable)
        {
            _testsTable = testsTable;
            _studyTable = studyTable;
            sfd.Filter = "Word Documents (*.doc)|*.doc";

            _parameters = new DynamicParams();
        }

        public void saveAll()
        {
            saveResultsTest();
            saveResultsStudy();
        }

        public void saveResultsTest()
        {
            _typeRes1 = "Экзамен";
            _typeRes2 = "Тестирование";
            saveResults();
            testsSaved = true;
        }
        public void saveResultsStudy()
        {
            _typeRes1 = "Тренировка";
            _typeRes2 = "Обучение";
            saveResults();
            studySaved = true;
        }

        public void saveResults()
        {
            listColumns = new Dictionary<string, string> { };
            dicCourses = new Dictionary<string, List<Result>> { };
            docnameAndResults = new Dictionary<string, List<DataGridViewRow>> { };

            foreach (Result res in ResultsData.Get())
            {
                if (res.ResultType != _typeRes1) continue;
                if (!dicCourses.ContainsKey(res.Course)) dicCourses.Add(res.Course, new List<Result> { });
                dicCourses[res.Course].Add(res);

            }

            //Коллекция для создания заголовков
            listColumns.Add("Course", "Предмет");
            listColumns.Add("TestName", "Название Теста");
            listColumns.Add("Platoon", "Взвод");
            listColumns.Add("StudentName", "ФИО");
            listColumns.Add("Mark", "Результат");
            listColumns.Add("Timestamp", "Дата");


            foreach (KeyValuePair<string, List<Result>> keyValue in dicCourses)
            {
                docnameAndResults.Clear();
                var wrongSymbols = "/\\<>:?\"|*";
                //Создаем папку под каждый предмет
                string courseDir = _parameters.Get().ResultsPath + @"\" + new string(_typeRes2.Where(c => !wrongSymbols.Contains(c)).ToArray()) + @"\" + new string(keyValue.Key.Where(c => !wrongSymbols.Contains(c)).ToArray());

                
                if (!Directory.Exists(courseDir))
                {
                    Directory.CreateDirectory(courseDir);
                }

                //Создание таблицы, которую вставим в Word
                DataGridView tempTable = new DataGridView();

                //Добаляем заголовочную строку таблице
                foreach (KeyValuePair<string, string> courseNameAndText in listColumns)
                {
                    var column = new DataGridViewColumn
                    {
                        HeaderText = courseNameAndText.Value,
                        Name = courseNameAndText.Key,
                        CellTemplate = new DataGridViewTextBoxCell()
                    };
                    tempTable.Columns.Add(column);
                }
                
                //Создание мапы <взвод - название теста> в конкретном предмете
                foreach (Result res in keyValue.Value)
                {
                    string name = res.Platoon + "взвод. " + res.TestName;
                    if (!docnameAndResults.ContainsKey(name))
                    {
                        docnameAndResults.Add(name, new List<DataGridViewRow> { });
                    }
                    

                    DataGridViewRow rowForInsert = new DataGridViewRow();
                    rowForInsert.CreateCells(_testsTable);
                    rowForInsert.Cells[0].Value = res.Course;
                    rowForInsert.Cells[1].Value = res.TestName;
                    rowForInsert.Cells[2].Value = res.Platoon;
                    rowForInsert.Cells[3].Value = res.StudentName;
                    rowForInsert.Cells[4].Value = res.Mark;
                    rowForInsert.Cells[5].Value = res.Timestamp;

                    

                    docnameAndResults[name].Add(rowForInsert);
                }

                foreach (var keyValueDocAndRows in docnameAndResults)
                {
                    tempTable.Rows.Clear();
                    foreach (DataGridViewRow rowTemp in keyValueDocAndRows.Value)
                    {
                        DataGridViewRow rowForInsert = new DataGridViewRow();
                        rowForInsert = (DataGridViewRow)rowTemp.Clone();

                        int intColIndex = 0;
                        foreach (DataGridViewCell cell in rowTemp.Cells)
                        {
                            rowForInsert.Cells[intColIndex].Value = cell.Value;
                            intColIndex++;
                        }

                        tempTable.Rows.Add(rowForInsert);
                    }

                    ws.Export_Data_To_Word(tempTable, courseDir + @"\" + new string(keyValueDocAndRows.Key.Where(c => !wrongSymbols.Contains(c)).ToArray()) + ".doc");
                }
            }

        }
    }
}
