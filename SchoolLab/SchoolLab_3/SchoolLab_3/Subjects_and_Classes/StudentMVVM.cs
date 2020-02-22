using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLab_3
{
    public class StudentMVVM
    {
        // Студент.
        private Student selectStudent;
        public Student SelectStudent 
        { 
            get { return selectStudent; }
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Гриша";
    }
}
