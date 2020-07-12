using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using VoenKaffServer.Properties;
using VoenKaffServer.Wrappers;


namespace VoenKaffServer
{
    public partial class FormDeleteResults : Form
    {
        List<string> _listOfCourses = new List<string> { };
        Panel panelWithCourses;
        DynamicParams _parameters = new DynamicParams();

        public FormDeleteResults()
        {
            InitializeComponent();
            foreach (Result res in ResultsData.Get())
            {
                if (!_listOfCourses.Contains(res.Course)) _listOfCourses.Add(res.Course);
            }
            
            drawCourses();
        }

        public void drawCourses()
        {
            panelWithCourses = (Panel)Controls.Find("panelCourses", true)[0];

            
            for (int i = 0; i < _listOfCourses.Count; i++)
            {
                CheckBox checkBoxForInsert = createCheckBoxCourse(_listOfCourses[i], i);
                panelWithCourses.Controls.Add(checkBoxForInsert);
            }
        }

        public CheckBox createCheckBoxCourse(string nameCourse, int koef)
        {
            CheckBox cb = new CheckBox();

            cb.AutoSize = true;
            cb.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            cb.Location = new System.Drawing.Point(24 , 21 + 20 * koef);
            cb.Name = "checkBox" + nameCourse;
            cb.Size = new System.Drawing.Size(218, 25);
            cb.TabIndex = koef;
            cb.Text = nameCourse;
            cb.UseVisualStyleBackColor = true;
            cb.CheckedChanged += new EventHandler(checkBox_CheckedChanged);

            return cb;
        }

        private void checkBox_CheckedChanged(Object sender, EventArgs e)
        {
            Boolean poo = false;
            foreach (Control ctrl in panelWithCourses.Controls)
            {
                if (((CheckBox)ctrl).Checked)
                {
                    poo = true;
                }
            }

            deleteResButton.Enabled = poo;

        }

        private void deleteResButton_Click(object sender, EventArgs e)
        {
            FormInputPassword fip = new FormInputPassword(this);
            this.Visible = false;
            fip.Visible = true;

        }

        public void deleteCheckedResults()
        {
            foreach (Control ctrl in panelWithCourses.Controls)
            {
                if (ctrl is CheckBox)
                {
                    if (((CheckBox)ctrl).Checked)
                    {
                        ResultsData.Get().RemoveAll(p => p.Course == ctrl.Text);
                        DirectoryInfo diTests = new DirectoryInfo(_parameters.Get().ResultsPath + @"\Тестирование\" + ctrl.Text);
                        DirectoryInfo diStudy = new DirectoryInfo(_parameters.Get().ResultsPath + @"\Обучение\" + ctrl.Text);

                        if (!diTests.Exists || !diStudy.Exists) continue;

                        foreach (FileInfo file in diTests.GetFiles())
                        {
                            file.Delete();
                        }
                        foreach (DirectoryInfo dir in diTests.GetDirectories())
                        {
                            dir.Delete(true);
                        }
                        foreach (FileInfo file in diStudy.GetFiles())
                        {
                            file.Delete();
                        }
                        foreach (DirectoryInfo dir in diStudy.GetDirectories())
                        {
                            dir.Delete(true);
                        }
                    }
                }
            }

            File.WriteAllText(Resources.ResultsData, JsonConvert.SerializeObject(ResultsData.Get()));
            MessageBox.Show("Результаты удалены","Успех!");

        }
    }
}
