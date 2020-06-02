using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks.Sources;

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
    
              input.ForEach(s => Console.WriteLine("Name: " + s.Name + " Age:  " + s.Age.ToString()));
              Console.WriteLine();
            
        }

        //1. Find all students aged 21 and over
        public void FindAllStudentsAged21AndOver()
        {
            List<Student> output = new List<Student>();
            output = Students.Where(s => s.Age >= 21).ToList();

            PrintStudents(output);

        }

        //2. Find the oldest student
        public void FindTheOldestStudent()
        {
            var output = Students.Where(s => s.Age == Students.Max(s => s.Age)).ToList();

            Console.WriteLine("The oldest student is:   ");
        
            PrintStudents(output);
         
        }

        //3. Find the youngest student
        public void FindTheYoungestStudent()
        {
            var output = Students.Where(s => s.Age == Students.Min(s => s.Age)).ToList();

            Console.WriteLine("The youngest student is:   ");

            PrintStudents(output);
        }

        //4. Find the oldest student under the age of 25

        public void FindTheOldestStudentUnder25()
        {
            var studentsUnder25 = Students.Where(s => s.Age <= 25).ToList();
            var output = studentsUnder25.Where(s => s.Age == studentsUnder25.Max(s => s.Age)).ToList();

            Console.WriteLine("The oldest student under 25 is:   ");

            PrintStudents(output);

        }

        //5. Find all students over 21 and with even ages

        public void FindAllStudentsOver21AndWithEvenAges()
        {
            var studentsOver21 = Students.Where(s => s.Age >= 21).ToList();
            var output = studentsOver21.Where(s => s.Age % 2 == 0).ToList();

            Console.WriteLine("All students over 21 and with even ages are:   ");

            PrintStudents(output);
        }

        //6. Find all teenage students (13 to 19 inclusive)
        public void FindAllTeenageStudents()
        {
            var output = Students.Where(s => s.Age >= 13 && s.Age <=19).ToList();

            Console.WriteLine("All students between the ages of 13 and 19, inclusive, are:   ");

            PrintStudents(output);
        }

        //7. Find all students whose name starts with a vowel
        public void FindAllStudentsWhoseNameStartsWithAVowel()
        {
            var output = Students.Where(s => "aeiou".IndexOf(s.Name.Substring(0, 1).ToLower())>-1).ToList();

            Console.WriteLine("All students whose name starts with a vowel are:   ");

            PrintStudents(output);
        }


    }
}
