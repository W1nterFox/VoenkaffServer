using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VoenKaffServer
{
    public partial class FormInputPassword : Form
    {
        FormDeleteResults _fdr;
        public FormInputPassword(FormDeleteResults fdr)
        {
            InitializeComponent();
            _fdr = fdr;
        }

        

        private void FormInputPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            _fdr.Visible = true;
        }

        private void buttonContinueDelete_Click(object sender, EventArgs e)
        {
            if (new DynamicParams().PwdIsValid(textBoxPassword.Text))
            {
                Hide();
                textBoxPassword.Text = "";

                _fdr.deleteCheckedResults();
            }
            else
            {
                MessageBox.Show("Пароль введен неверно. \nПовторите ввод снова");
            }
        }
    }
}
