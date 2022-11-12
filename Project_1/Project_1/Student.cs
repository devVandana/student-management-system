using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_1
{
    public class Student
    {   

        public Student(string name, string gender,int age , string region) {
            Name = name;
            Gender = gender;
            Age = age;
            Region = region;
            courses = new List<string>();
        }
        public string Name { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string Region { get; set; }

        public List<string> courses;

        
    }
}
