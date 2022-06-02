using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_оор.Models
{
   public class Teacher
    {
        public string Course_Name { get; set; }
        public string Teacher_Name { get; set; }
        public string Lectures { get; set; }
        public string Students { get; set; }
        public int Taloncick { get; set; }

        public Teacher(string course_name, string teacher_name, string lectures, string students, int taloncick)
        {
            this.Course_Name = course_name;
            this.Teacher_Name = teacher_name;
            this.Lectures = lectures;
            this.Students = students;
            this.Taloncick = taloncick;
        }
    }
}
