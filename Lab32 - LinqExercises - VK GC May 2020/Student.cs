using System;
using System.Collections.Generic;
using System.Text;

namespace Lab32___LinqExercises___VK_GC_May_2020
{
    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Student()
        {

        }
        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
