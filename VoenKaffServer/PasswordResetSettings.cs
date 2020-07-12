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
    public partial class PasswordResetSettings : Form
    {
        public PasswordResetSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dynamicParams = new DynamicParams();
            if (dynamicParams.PwdIsValid(OldPassword.Text))
            {
                if (NewPassowrdRepeater.Text == NewPassword.Text)
                {
                    dynamicParams.SetPwd(NewPassword.Text);
                    MessageBox.Show("Новый пароль сохранен", "Новый пароль сохранен", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    NewPassowrdRepeater.Text = "";
                    NewPassword.Text = "";
                    OldPassword.Text = "";
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Новые пароли не совпадают", "Новые пароли не совпадают", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Старый пароль введен неверно", "Старый пароль введен неверно", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
