using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Lab32___LinqExercises___VK_GC_May_2020
{
    class Solution
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public Solution(List<Student> testData)
        {
            this.Students = testData;
        }

        public void PrintStudents(List<Student> input)
        {
            foreach(Student s in input)
            {
                Console.WriteLine("Name:  " + s.Name);
                Console.WriteLine("Age:   " + s.Age);
                Console.WriteLine();
            }
        }

        //1. Find all students aged 21 and over
        public List<Student> FindAllStudentsAged21AndOver()
        {
            List<Student> output = new List<Student>();
            output = Students.Where(s => s.Age >= 21).ToList();

            PrintStudents(output);
            return output;
        }
        
        //2. Find the oldest student
        public List<Student> FindTheOldestStudent()
        {
            //output = Students.Where(s => s.Age).Max();
            //var output = Students.Where(s => s.Age == Students.Max(s => s.Age));
            //return (List<Student>)output;

            List<Student> output = new List<Student>();

            var results = (from s in Students where s.Age == search select s).Max();

            output = results.Max();
            PrintStudents(output);
            return output;
        }


    }
}
