using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                foreach (User user in db.Users)
                {
                    if (textBox1.Text == user.Login && this.GetHashString(textBox2.Text) == user.Password)
                    {
                        Form4 userForm = new Form4();
                        MessageBox.Show("Вход успешен!");
                        userForm.label1.Text = ("Логин: ") + user.Login;
                        userForm.label2.Text = ("Имя: ") + user.Name;
                        userForm.label3.Text = ("Фамилия: ") + user.Surname;
                        userForm.label4.Text = ("Дата рождения: ") + user.Birthday;
                        userForm.label5.Text = ("Email: ") + user.Email;
                        userForm.label6.Text = ("Номер телефона: ") + user.Number;
                        userForm.label7.Text = ("Отдел: ") + user.Department;
                        userForm.label8.Text = ("Должность: ") + user.Post;
                        userForm.label9.Text = ("Зарплата: ") + user.Salary;
                        userForm.label10.Text = ("Дата приема на работу: ") + user.Firstdata;

                        userForm.Show();

                        this.Visible = false;
                        return;
                    }
                }
                MessageBox.Show("Логин или пароль указан неверно!");
            }
        }
        private string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = "";
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }
    }
}
