using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Faculty
    {
        public Faculty(string name, string gender, int age, string expertise)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Expertise = expertise;
            courses = new List<string>();
        }
        public string Name { get; set; }

        public string Expertise { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public  List<string> courses;
    }
}
