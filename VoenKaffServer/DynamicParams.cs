using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VoenKaffServer
{
    public class DynamicParams
    {
        private const string Path = "settingsServer.ini"; //Имя файла.

        // С помощью конструктора записываем пусть до файла и его имя.
        public DynamicParams()
        {
            if (!File.Exists(Path))
            {
                File.Create(Path);
            }
        }

        public class Settings
        {
            public string TestPath { get; set; } = "";
            public int Port { get; set; } = 8080;
            public string IpAdress { get; set; } = "127.0.0.1";
            public string ResultsPath { get; set; } = "";
            public string Pwd { get; set; }
        }


        //Читаем ini-файл и возвращаем значение указного ключа из заданной секции.
        public Settings Get()
        {
            return ReadFile();
        }

        private Settings ReadFile()
        {
            using (var stream = new FileStream(Path, FileMode.Open))
            {
                try
                {
                    var serializer = new XmlSerializer(typeof(Settings));
                    var iniSet = (Settings)serializer.Deserialize(stream);
                    return iniSet;
                }
                catch (Exception)
                {
                    return new Settings();
                }
            }
        }
        //Записываем в ini-файл. Запись происходит в выбранную секцию в выбранный ключ.
        public void SetTestPath(string value)
        {
            var iniFile = ReadFile();
            iniFile.TestPath = value;
            using (var stream = new FileStream(Path, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(Settings));
                serializer.Serialize(stream, iniFile);
            }
        }
        public void SetResultsPath(string value)
        {
            var iniFile = ReadFile();
            iniFile.ResultsPath = value;
            using (var stream = new FileStream(Path, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(Settings));
                serializer.Serialize(stream, iniFile);
            }
        }

        public void SetIp(string value)
        {
            var iniFile = ReadFile();
            iniFile.IpAdress = value;
            using (var stream = new FileStream(Path, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(Settings));
                serializer.Serialize(stream, iniFile);
            }
        }

        public void SetPwd(string value)
        {
            
                var iniFile = ReadFile();
                iniFile.Pwd = HashPassword(value);
                using (var stream = new FileStream(Path, FileMode.Create))
                {
                    try
                    {
                        var serializer = new XmlSerializer(typeof(Settings));
                        serializer.Serialize(stream, iniFile);
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
            
        }

        public bool PwdIsValid(string pwd)
        {
            try
            {
                var pass = ReadFile().Pwd;
                if (pass == null && pwd == "admin")
                {
                    SetPwd("admin");
                    return true;
                }
                var hash = HashPassword(pwd);
                return pass == hash;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private string HashPassword(string password)
        {
                Byte[] inputBytes = Encoding.UTF8.GetBytes(password);

                Byte[] hashedBytes = new SHA256CryptoServiceProvider().ComputeHash(inputBytes);

                return BitConverter.ToString(hashedBytes);
        }

        public void SetPort(int value)
        {
                var iniFile = ReadFile();
                iniFile.Port = value;
                using (var stream = new FileStream(Path, FileMode.Create))
                {
                    try
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                        serializer.Serialize(stream, iniFile);
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
            }
            
        }

    }
}
