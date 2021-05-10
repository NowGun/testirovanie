using System;
using System.Windows.Forms;

namespace testirovanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string[] conf = System.IO.File.ReadAllLines("C:\\testirovanie\\config.txt");
            string[] loginname = { "admin", "Admin" };
            string[] passwordname = { "admin", "123" };
            if (login.Text == conf[1] && password.Text == conf[3])
            {
                MessageBox.Show("Вход выполнен успешно");
                Controls.Clear();
            }
            else label4.Text = "Логин или пароль введен неверно";
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            registerform regform = new registerform();
            regform.Show();
        }
    }
}
