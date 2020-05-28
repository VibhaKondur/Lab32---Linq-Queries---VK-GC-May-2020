using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Lab32___LinqExercises___VK_GC_May_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums =  { 10, 2330, 112233, 748394, 10, 949, 3764, 2942, 35, 6, 3 };

            //For nums
            //1.Find the minimum value
            int minValue = nums.Min();
            Console.WriteLine("Minimum Value: {0}", minValue);

            //2. Find the maximum value
            int maxValue = nums.Max();
            Console.WriteLine("Maximum Value: {0}", maxValue);

            //3. Find the Maximum value less than 10000
            int maxNumber = (from x in nums where x < 10000 select x).Max();
            Console.WriteLine("Maximum Value less than 10,000: {0}", maxNumber);

            //4. Find all values between 10 and 100
            //List<int> numbers = new List<int> { 10, 2330, 112233, 748394, 10, 949, 3764, 2942, 35, 6, 3 };

            var values = (from n in nums where n >= 10 && n <= 100 select n);
            Console.WriteLine("All numbers between 10 and 100: {0}", values);

            //List<int> numbersOutput = values.ToList();
            //foreach( int n in numbersOutput)
            //{
            //    
            //}

            //5. Find all Values between 100000 and 999999 inclusive
            var allValues = (from n in nums where n >= 100000 && n <= 999999 select n);
            Console.WriteLine("All numbers between 100,000 and 999,999: {0}", allValues);
            
            //List<int> numbersAnswer = allValues.ToList();
            //foreach (int y in numbersAnswer)
            //{
            //    
            //}

            //6. Count all the even numbers 
            int allEvenNumbers = nums.Where(a => a % 2 == 0).Count();
            Console.WriteLine("All even numbers: {0}", allEvenNumbers);

            //For Students
            List<Student> Students = new List<Student>();
            Students.Add(new Student("Jimmy", 13));
            Students.Add(new Student("Hannah Banana", 21));
            Students.Add(new Student("Justin", 30));
            Students.Add(new Student("Sarah", 53));
            Students.Add(new Student("Hannibal", 15));
            Students.Add(new Student("Philip", 16));
            Students.Add(new Student("Maria", 63));
            Students.Add(new Student("Abe", 33));
            Students.Add(new Student("Curtis", 10));

            Solution s = new Solution(Students);
            
            s.FindAllStudentsAged21AndOver();
            s.FindTheOldestStudent();
            //s.FindTheYoungestStudent();
            //s.FindTheOldestStudentUnder25
            //s.FindAllStudentsOver21AndWithEvenAges
            //s.FindAllTeenageStudents
            //s.FindAllStudentsWhoseNameStartsWithAVowel

        }
    }
}
