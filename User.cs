using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp1
{ 
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Department { get; set; }
        public string Post { get; set; }
        public string Salary { get; set; }
        public string Firstdata { get; set; }
        public User() { }
        public User(string Login, string Password, string Name, string Surname, string Birthday, string Email, string Number, string Department, string Post, string Salary, string Firstdata)
        {
            this.Login = Login;
            this.Password = Password;
            this.Name = Name;
            this.Surname = Surname;
            this.Birthday = Birthday;
            this.Email = Email;
            this.Number = Number;
            this.Department = Department;
            this.Post = Post;
            this.Salary = Salary;
            this.Firstdata = Firstdata;
        }
    }
}
