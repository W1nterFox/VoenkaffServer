using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoenKaffServer
{
    public partial class FormLogin : Form
    {
        FormStart _formStart;
        public FormLogin()
        {
            InitializeComponent();
            _formStart = new FormStart(this);


            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void buttonGoAdmin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя и пароль");
                return;
            }

            if (textBoxLogin.Text == "admin" && new DynamicParams().PwdIsValid(textBoxPassword.Text))
            {
                //MessageBox.Show("Login Successful!");
                Hide();
                _formStart.Show();
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Имя пользователя или пароль введены неверно. \nПовторите ввод снова");
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {



            if (_formStart.resultsSaver.testsSaved == false || _formStart.resultsSaver.testsSaved == false)
            {
                var messageBox = MessageBox.Show("Закрыть без сохранения результатов? \n(Чтобы сохранить результаты, войдите как преподаватель)", "Есть несохраненные результаты!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (messageBox == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                if (messageBox == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
            else
            {
                Environment.Exit(0);
            }
            
        }
    }
}
