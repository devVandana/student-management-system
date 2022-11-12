using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Project_1
{
    internal class Courses
    {
        public Courses(int Duration,  int No_of_books, string Type)
        {
            duration = Duration;
            type = Type;
            no_of_books =  No_of_books;
            students = new List<string>();
        }
        public int duration { get; set; }
        public int faculty_id { get; set; }

        public string type { get; set; }

        public int no_of_books { get; set; }

        public static List<string> students;
    }
}
