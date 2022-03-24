using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioGenericsSetDictionary.Entities;

namespace ExercicioGenericsSetDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Courses courseA = new Courses();
            Courses courseB = new Courses();
            Courses courseC = new Courses();

            Console.Write("How many students for course A? ");
            int numberStudents = int.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            for (int i = 0; i < numberStudents; i++)
            {
                Students student = new Students("Peter", int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                courseA = new Courses()
                {
                    Student = student,
                    NameCourse = "A"
                };
                courseA.Course.Add(courseA.Student.Number);
            }
            Console.Write("How many students for course B? ");
            numberStudents = int.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            for (int i = 0; i < numberStudents; i++)
            {
                Students student = new Students("Peter 1", int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                courseB.Student = student;
                courseB.NameCourse = "B";
                courseB.Course.Add(courseB.Student.Number);
            }
            Console.Write("How many students for course C? ");
            numberStudents = int.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            for (int i = 0; i < numberStudents; i++)
            {
                Students student = new Students("Peter 2", int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                courseC.Student = student;
                courseC.NameCourse = "C";
                courseC.Course.Add(courseC.Student.Number);
            }


            HashSet<int> allCourses = new HashSet<int>();

            allCourses.UnionWith(courseA.Course);
            allCourses.UnionWith(courseB.Course);
            allCourses.UnionWith(courseC.Course);
            Console.WriteLine("Total students: " + allCourses.Count);
        }
    }
}
