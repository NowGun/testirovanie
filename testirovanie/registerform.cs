using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace testirovanie
{
    public partial class registerform : Form
    {
        public registerform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("C:\\testirovanie");
            FileStream file1 = new FileStream("C:\\testirovanie\\config.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            string loginname = login.Text;
            string passwordname = password.Text;
            if (loginname != string.Empty && passwordname != string.Empty)
            {
                
                writer.WriteLine("Логин:");
                writer.WriteLine("" + loginname);
                writer.WriteLine("Пароль:");
                writer.WriteLine("" + passwordname);
                writer.Close();
                MessageBox.Show("Регистрация успешно завершена");
                Close();
            }
            else label2.Text = "Заполните поле";
        }

        private void login_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
        }

        private void password_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
        }
    }
}
