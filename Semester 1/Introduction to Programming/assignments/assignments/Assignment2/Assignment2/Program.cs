/*
 * Programmer: Saeed Mirjalili
 * Date: Fall 2020
 * Purpose: This program calculates the weighted average total grade of students
 */

using System;
using static System.Console;  // adding this Using Directive, I do not need to add Console class name in front of
                              // Write and WriteLine and ReadKey Methods

namespace WeightedAverageCalc
{
    class WAC
    {
        static void Main(string[] args)
        {
            // constant weights are defined here, on top of a method
            // all consts must be written in ALL_CAPS Style
            const float ASSIGNMENTS_PERCENTAGE = 0.2f;
            const float MIDTERM_EXAM_PERCENTAGE = 0.3f;
            const float QUIZZES_PERCENTAGE = 0.2f;
            const float FINAL_EXAM_PERCENTAGE = 0.3f;

            // grades of students are initialized here, on top of a method
            // all variables must be written in cameCase Style
            float assignments = 100;
            float midtermExam = 55;
            float quiz1 = 45.5f;
            float quiz2 = 100;
            float finalExam = 65.80f;

            float weightedExams;
            float totalWeightedAverage;

            totalWeightedAverage = assignments * ASSIGNMENTS_PERCENTAGE + midtermExam * MIDTERM_EXAM_PERCENTAGE + (quiz1 + quiz2) * QUIZZES_PERCENTAGE / 2 + finalExam * FINAL_EXAM_PERCENTAGE;

            Title = "CSIS1175 - Assignment 2 - By Saeed Mirjalili";
            Write("\\***************************************\\\n");
            Write("\\\t\t\t\t\t\\\n");
            Write("\\  \"Total Weighted Average Calculator\"  \\\n");
            Write("\\\t\t\t\t\t\\\n");
            Write("\\***************************************\\\n");

            WriteLine();

            WriteLine("{0,14}{1,13}   {2,-12}", "Assessment", "Percentage", "Your Grade");
            WriteLine("{0,14}{1,13}   {2,-15}", "--------------", " -----------", "----------");
            WriteLine("{0,14}{1,13:P0}   {2,-15}", "Assignments", ASSIGNMENTS_PERCENTAGE, assignments);
            WriteLine("{0,14}{1,13:P0}   {2,-15}", "MidTerm Exam", MIDTERM_EXAM_PERCENTAGE, midtermExam);
            WriteLine("{0,14}{1,13:P0}   {2,-15}", "Quiz1", QUIZZES_PERCENTAGE / 2, quiz1);
            WriteLine("{0,14}{1,13:P0}   {2,-15}", "Quiz2", QUIZZES_PERCENTAGE / 2, quiz2);
            WriteLine("{0,14}{1,13:P0}   {2,-15}", "Final Exam", FINAL_EXAM_PERCENTAGE, finalExam);
            WriteLine("----------------------------------------");
            WriteLine("{0,14}{1,13:P0}   {2,-15:F2}", "Weighted Total", "100%", totalWeightedAverage);
            WriteLine("\n");

            weightedExams = (float)((midtermExam * MIDTERM_EXAM_PERCENTAGE + (quiz1 + quiz2) * QUIZZES_PERCENTAGE / 2 + finalExam * FINAL_EXAM_PERCENTAGE) / 0.8);

            WriteLine("The Weighted Average Total (WAT) on Exams (Midterm, Quizzes, Final exam) is {0:F2}", weightedExams);
            WriteLine("If WAT-on-Exams is less than 50, the student fails the course.");

            ReadKey();
        }
    }
}
