using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoenKaffServer
{
    public partial class FormSettings : Form
    {
        private readonly DynamicParams _parameters;
        public FormSettings()
        {
            InitializeComponent();
            _parameters = new DynamicParams();
            Port.Text = _parameters.Get().Port.ToString();
            TestDirectory.Text = _parameters.Get().TestPath;
            IpAddress.Text = _parameters.Get().IpAdress;
            resultsDirectory.Text = _parameters.Get().ResultsPath;


            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void Port_Leave(object sender, EventArgs e)
        {
            var portValue = ((Control)sender).Text;
            int port;
            if (portValue != null && Int32.TryParse(portValue, out port) && port > 0 && port <= 65535)
            {
                _parameters.SetPort(port);
            }
            else
            {
                MessageBox.Show("Неверно задан порт!", "Неправильное значение порта", MessageBoxButtons.OK);
                Port.Text = "";
            }

        }

        private void TestDirectory_Leave(object sender, EventArgs e)
        {
            var testDirectoryValue = ((Control)sender).Text;
            if (Directory.Exists(testDirectoryValue))
            {
                _parameters.SetTestPath(testDirectoryValue);
            }
            else
            {
                var result = MessageBox.Show("Такой директории не существует, создать?", "Директория не существует", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    try
                    {
                        Directory.CreateDirectory(testDirectoryValue);
                        if (!Directory.Exists(testDirectoryValue))
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Не удалось создать директорию", "Не удалось создать директорию",
                            MessageBoxButtons.OK);
                        ((Control)sender).Text = "";
                    }
                }
                else
                {
                    ((Control) sender).Text = "";
                }
            }
        }

        private void resultsDirectory_Leave(object sender, EventArgs e)
        {
            var resultsDirectoryValue = ((Control)sender).Text;
            if (Directory.Exists(resultsDirectoryValue))
            {
                _parameters.SetResultsPath(resultsDirectoryValue);
            }
            else
            {
                var result = MessageBox.Show("Такой директории не существует, создать?", "Директория не существует", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        //Главная папка
                        Directory.CreateDirectory(resultsDirectoryValue);
                        
                        if (!Directory.Exists(resultsDirectoryValue))
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Не удалось создать директорию", "Не удалось создать директорию", MessageBoxButtons.OK);
                        ((Control)sender).Text = "";
                    }
                }
                else
                {
                    ((Control)sender).Text = "";
                }
            }
        }

        private void IpAddress_Leave(object sender, EventArgs e)
        {
            Regex ip = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");
            var obj = (TextBox)sender;
            if (ip.IsMatch(obj.Text))
            {
                _parameters.SetIp(obj.Text);
            }
            else
            {
                MessageBox.Show("Неверно задан ip-адрес!", "Неправильное значение ip-адреса", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        
    }
}
