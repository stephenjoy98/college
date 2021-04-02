using System;

namespace assignment6
{
    class Student
    {
        public Student(int numberOfCourses)
        {
            Grades = new float[numberOfCourses];
        }

        public static string Name { get; set; }
        public static float GPA { get; set; }
        public static float[] Grades { get; set; }


        public static void GetGPA()
        {
            float total = 0;
            for (int i = 0; i < Grades.Length; i++)
            {
                total += Grades[i];
            }
            GPA = total / Grades.Length;
        }
    }
}