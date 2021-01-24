/*
Programmer: Stephen Joy
Date: Winter 2021
Purpose: To practice and understand the use of variables, data types, strings and constants and proper formatting of numbers
*/

using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            const float ASSIGNMENTS_PERCENTAGE = 0.2f;
            const float MIDTERM_PERCENTAGE = 0.3f;
            const float QUIZ_PERCENTAGE = 0.2f;
            const float FINALEXAM_PERCENTAGE = 0.3f;

            /*int assignments = 100;
            int midtermExam = 55;
            float quiz1 = 45.5f;
            int quiz2 = 100;
            float finalExam = 65.8f;*/

            int assignments = 90;
            int midtermExam = 65;
            int quiz1 = 60;
            int quiz2 = 75;
            int finalExam = 50;

            /*int assignments = 95;
            int midtermExam = 65;
            int quiz1 = 80;
            int quiz2 = 95;
            int finalExam = 60;*/

            /*int assignments = 80;
            int midtermExam = 86;
            int quiz1 = 90;
            int quiz2 = 95;
            int finalExam = 78;*/

            /*int assignments = 100;
            int midtermExam = 0;
            float quiz1 = 45.5f;
            int quiz2 = 100;
            float finalExam = 65.8f;*/

            float weightedAverageTotal = (assignments * ASSIGNMENTS_PERCENTAGE + midtermExam * MIDTERM_PERCENTAGE + (quiz1 + quiz2) * QUIZ_PERCENTAGE / 2 + finalExam * FINALEXAM_PERCENTAGE) / (ASSIGNMENTS_PERCENTAGE + MIDTERM_PERCENTAGE + QUIZ_PERCENTAGE + FINALEXAM_PERCENTAGE);
            float weightedExams = (midtermExam * MIDTERM_PERCENTAGE + (quiz1 + quiz2) * QUIZ_PERCENTAGE/2 + finalExam * FINALEXAM_PERCENTAGE) / (MIDTERM_PERCENTAGE + QUIZ_PERCENTAGE + FINALEXAM_PERCENTAGE);

            Console.Write("\\***************************************\\\n");
            Console.Write("\\ \t\t\t\t\t\\\n");
            Console.Write("\\  \"Total Weighted Average Calculator\"  \\\n");
            Console.Write("\\ \t\t\t\t\t\\\n");
            Console.Write("\\***************************************\\\n\n");

            Console.WriteLine("{0,14}{1,13}   {2,-1}","Assessments","Percentage","Your Grade");
            Console.WriteLine("{0,14}{1,13}   {2,-15}","--------------","----------","----------");
            Console.WriteLine("{0,14}{1,13:p0}   {2,-15}","Assignments",ASSIGNMENTS_PERCENTAGE,assignments);
            Console.WriteLine("{0,14}{1,13:p0}   {2,-15}", "MidTerm Exam",MIDTERM_PERCENTAGE,midtermExam);
            Console.WriteLine("{0,14}{1,13:p0}   {2,-15}", "Quiz1", (QUIZ_PERCENTAGE / 2), quiz1);
            Console.WriteLine("{0,14}{1,13:p0}   {2,-15}", "Quiz2", (QUIZ_PERCENTAGE / 2),quiz2);
            Console.WriteLine("{0,14}{1,13:p0}   {2,-15}", "Assignments", FINALEXAM_PERCENTAGE,finalExam);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("{0,14}{1,13:p0}   {2,-15:F2} \n", "Weighted Total", 1, weightedAverageTotal);

            Console.WriteLine("\nThe Weighted Average Total (WAT) on Exams (Midterm, Quizses, Final exam) is {0:F2}", weightedExams);
            Console.Write("If WAT-on-Exam is less than 50, the student fails the course.");

            Console.ReadKey();
        }
    }
}
