using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using VoenKaffServer.Properties;
using VoenKaffServer.Wrappers;

namespace VoenKaffServer
{
    public partial class FormStart : Form
    {
        delegate void StringArgReturningVoidDelegate(string text);
        private FormSettings _settings;

        FormLogin _formLogin;
        public ResultsSaver resultsSaver;
        private PasswordResetSettings passwordReseter;

        public FormStart(FormLogin formLogin)
        {
            InitializeComponent();
            _formLogin = formLogin;
            ResultInitializer();
            var listener = new Listener(this);
            listener.Start();


            resultsSaver = new ResultsSaver(GridResultTest, GridResultStudy);

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void Initialize()
        {
            var json = File.ReadAllText(Resources.ResultsData);
            AddResult(json);
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_settings == null || _settings.IsDisposed)
            {
                _settings = new FormSettings();
            }
            _settings.Visible = true;
        }

        public void AddResult(string result)
        {
            if (GridResultTest.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = AddResult;
                Invoke(d, result);
            }
            else
            {
                var resultObj = JsonConvert.DeserializeObject<Result>(result);                
                switch (resultObj.ResultType)
                {
                    case "Экзамен":
                        {
                            GridResultTest.Rows.Add(
                            resultObj.Course,
                            resultObj.TestName,
                            resultObj.Platoon,
                            resultObj.StudentName,
                            resultObj.Mark,
                            resultObj.Timestamp);
                            resultsSaver.testsSaved = false;
                            break;
                        }
                    case "Тренировка":
                        {
                            GridResultStudy.Rows.Add(
                            resultObj.Course,
                            resultObj.TestName,
                            resultObj.Platoon,
                            resultObj.StudentName,
                            resultObj.Mark,
                            resultObj.Timestamp);
                            resultsSaver.studySaved = false;
                            break;
                        }
                }              
                UpdateResults(
                    resultObj.Course,
                    resultObj.TestName,
                    resultObj.Platoon,
                    resultObj.StudentName,
                    resultObj.Mark,
                    resultObj.Timestamp,
                    resultObj.ResultType);
            }
        }

        private void UpdateResults(params object[] newRow)
        {
            ResultsData.Get().Add(new Result
            {
                ResultType = newRow[6] as string,
                Mark = newRow[4] as string,
                Platoon = newRow[2] as string,
                StudentName = newRow[3] as string,
                TestName = newRow[1] as string,
                Timestamp = (DateTime)newRow[5],
                Course = newRow[0] as string
            });
            File.WriteAllText(Resources.ResultsData, JsonConvert.SerializeObject(ResultsData.Get()));
        }

        private void GridResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResultInitializer()
        {
            if (File.Exists(Resources.ResultsData) && File.ReadAllText(Resources.ResultsData)!="")
            {
                var json = File.ReadAllText(Resources.ResultsData);
                var results = JsonConvert.DeserializeObject<List<Result>>(json);
                foreach (var result in results)
                {
                    ResultsData.Get().Add(result);
                    
                }
            }
            //UpdateResults();
        }

        private void выйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _formLogin.Visible = true;
        }

        private async void тестированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UpdateResults();
            this.Visible = false;

            FormPicWhileDocsAreSaving formLoading = new FormPicWhileDocsAreSaving();
            formLoading.Visible = true;
            if (await TaskEx.Run(() => goSaveTests()))
            {
                formLoading.Visible = false;
            }

            this.Visible = true;
        }

        private async void обучениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UpdateResults();
            this.Visible = false;

            FormPicWhileDocsAreSaving formLoading = new FormPicWhileDocsAreSaving();
            formLoading.Visible = true;
            if (await TaskEx.Run(() => goSaveStudy()))
            {
                formLoading.Visible = false;
            }

            this.Visible = true;
        }

        public Boolean goSaveTests()
        {
            resultsSaver.saveResultsTest();
            return true;
        }
        public Boolean goSaveStudy()
        {

            resultsSaver.saveResultsStudy();
            return true;
        }
        public async Task goSaveAll()
        {
            resultsSaver.saveAll();
            await TaskEx.Delay(1000);
            //return true;
        }
        public Boolean goSaveAll2()
        {
            resultsSaver.saveAll();
            return true;
        }




        private  void FormStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                saveResByClosing();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public async void saveResByClosing()
        {
            //UpdateResults();
            if (!resultsSaver.testsSaved || !resultsSaver.studySaved)
            {
                Visible = false;
                var formLoading = new FormPicWhileDocsAreSaving {Visible = true};
                await goSaveAll();
                formLoading.Visible = false;
                Environment.Exit(0);
            }
            else
            {
                Environment.Exit(0);
            }
            

        }

        private async void скачатьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UpdateResults();

            this.Visible = false;

            FormPicWhileDocsAreSaving formLoading = new FormPicWhileDocsAreSaving();
            formLoading.Visible = true;
            if (await TaskEx.Run(() => goSaveAll2()))
            {
                formLoading.Visible = false;
            }

            this.Visible = true;



        }

        private void сменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (passwordReseter == null || passwordReseter.IsDisposed)
            {
                passwordReseter=new PasswordResetSettings();
            }
            passwordReseter.Visible = true;
        }

        private void сохранитьРезультатыИТестыНаФлешкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var parameters = new DynamicParams();
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    var dirForBackup = fbd.SelectedPath + "/Результаты тестирования";
                    var fromDir = parameters.Get().ResultsPath;
                    if (!Directory.Exists(fromDir))
                    {
                        MessageBox.Show("В настройках не указан путь к папке с результатами или такой папки не существует", "Ошибка сохранения результатов", MessageBoxButtons.OK);
                        return;
                    }

                    CopyDir(fromDir, dirForBackup);

                    MessageBox.Show("Файлы с результатами успешно сохранены", "Успешно сохранено", MessageBoxButtons.OK);
                }
            }

            
        }

        private void CopyDir(string FromDir, string ToDir)
        {
            Directory.CreateDirectory(ToDir);
            
            foreach (string s1 in Directory.GetFiles(FromDir))
            {
                string s2 = ToDir + "\\" + Path.GetFileName(s1);
                File.Copy(s1, s2, true);
                
            }
            foreach (string s in Directory.GetDirectories(FromDir))
            {
                CopyDir(s, ToDir + "\\" + Path.GetFileName(s));
            }
        }

        private IEnumerable<string> GetDrives()
        {
            return DriveInfo.GetDrives().Where(p => p.DriveType == DriveType.Removable).Select(p => p.Name);
        }

        private void сохранитьТестыНаФлешкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var parameters = new DynamicParams();
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    var dirForBackup = fbd.SelectedPath + "/Тесты";
                    var fromDir = parameters.Get().TestPath;
                    if (!Directory.Exists(fromDir))
                    {
                        MessageBox.Show("В настройках не указан путь к папке с тестами или такой папки не существует", "Ошибка сохранения тестов", MessageBoxButtons.OK);
                        return;
                    }

                    CopyDir(fromDir, dirForBackup);

                    MessageBox.Show("Тесты успешно сохранены", "Успешно сохранено", MessageBoxButtons.OK);
                }
            }

        }

        private void загрузитьТестыСФлешкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var parameters = new DynamicParams();
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    var dirForBackup = fbd.SelectedPath;
                    var fromDir = parameters.Get().TestPath;
                    if (!Directory.Exists(fromDir))
                    {
                        MessageBox.Show("В настройках не указан путь к папке с тестами для сохранения или такой папки не существует", "Ошибка сохранения тестов", MessageBoxButtons.OK);
                        return;
                    }

                    CopyDir(dirForBackup, fromDir);

                    MessageBox.Show("Тесты успешно загружены", "Успешно загружено", MessageBoxButtons.OK);
                }
            }

        }

        private void удалениеРезультатовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeleteResults fdr = new FormDeleteResults();
            //this.Visible = false;
            fdr.Visible = true;
        }
    }
}
