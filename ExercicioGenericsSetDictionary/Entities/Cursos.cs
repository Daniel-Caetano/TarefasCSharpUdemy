using System.Collections.Generic;

namespace ExercicioGenericsSetDictionary.Entities
{
    internal class Courses
    {
        public string NameCourse { get; set; }
        public Students Student { get; set; }
        public HashSet<int> Course { get; set; }

        public Courses()
        {
            NameCourse = "";
            Student = new Students();
            Course = new HashSet<int>();
        }

        public Courses(string nomeCurso, Students student)
        {
            NameCourse = nomeCurso;
            Student = student;
            Course.Add(student.Number);
        }
        public override int GetHashCode()
        {
            return Student.Number.GetHashCode();
        }
        public override bool Equals(object student)
        {
            if( (student is Students) is false)
            {
                return false;
            }
            Students other = student as Students;
            return Student.Number.Equals(other.Number);
        }
    }
}
