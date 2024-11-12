using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Activity 1:");
            activity1();
            Console.WriteLine("Activity 2:");
            activity2();
            Console.WriteLine("Activity 3:");
            activity3();
            Console.WriteLine("Activity 4:");
            activity4();

            

        }


        static void activity1()
        {
                       List<int> numbers = new List<int>();
                        numbers.Add(6);
                        numbers.Add(7);
                        numbers.Add(4);
                        numbers.Add(3);
                        numbers.Add(0);

                        Console.WriteLine("Original list:");
                        foreach (int number in numbers)
                        {
                            Console.WriteLine(number);
                        }

                        numbers.Sort();

                        Console.WriteLine("Sorted list:");
                        foreach (int number in numbers)
                        {
                            Console.WriteLine(number);
                        }

                        numbers.Remove(6);

                        Console.WriteLine("After removing 6 in list:");
                        foreach (int number in numbers)
                        {
                            Console.WriteLine(number);
                        }
        }

        static void activity2()
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();
            countries["USA"] = "Washington DC";
            countries["France"] = "Paris";
            countries["Japan"] = "Tokyo ";
            countries["India"] = "Delhi ";
            Console.WriteLine("Countries and capitals");

            foreach (var pair in countries)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
            Console.WriteLine($"\n Capital of japan: {countries["Japan"]}");
        }


        static void activity3()
        {
            ArrayList arraylist = new ArrayList();
            arraylist.Add(10);
            arraylist.Add("Hello");
            arraylist.Add(20.5);
            arraylist.Add("Word");

            //Display
            Console.WriteLine("Array list elements:");
            foreach (var items in arraylist)
            {
                Console.WriteLine(items);
            }

            //Remove an item 

            arraylist.Remove("Hello");
            Console.WriteLine("After remove elements in Array list :");
            foreach (var items in arraylist)
            {
                Console.WriteLine(items);
            }
        }


        static void activity4()
        {
            Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();

            students["Alice"] = new List<int> { 85, 90, 88 };
            students["Bob"] = new List<int> { 70, 60, 75 };
            students["Carlie"] = new List<int> { 95, 92, 94 };
            students["Daisy"] = new List<int> { 55, 60, 58 };

            Console.WriteLine("Students average:");
            foreach (var student in students)
            {
                double average = student.Value.Average();
                Console.WriteLine($"{student.Key} : {average:F2}");
            }
            var topstudent = students.OrderByDescending(a => a.Value.Average()).First();
            var lowstudent = students.OrderBy(s => s.Value.Average()).First();

            Console.WriteLine($"Top performing student is:{topstudent.Key}");
            Console.WriteLine($"worst performing student is:{lowstudent.Key}");
            var failingStudent = students.Where(a => a.Value.Average() < 60).Select(a => a.Key).ToList();
            foreach (var student in failingStudent)
            {
                students.Remove(student);

            }
            Console.WriteLine("\n List of students:");
            foreach (var student in students)
            {
                double average = student.Value.Average();
                Console.WriteLine($"{student.Key} : {average:F2}");
            }
        }






    }
}
