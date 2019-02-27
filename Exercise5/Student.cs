using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Student
    {
        public string Name { get; set; }

        public string StudentNumber{get;set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Student(String name, string number, string mail, string phone)
        {
            Name = name;
            StudentNumber = number;
            Email = mail;
            Phone = phone;
        }
    }
}
