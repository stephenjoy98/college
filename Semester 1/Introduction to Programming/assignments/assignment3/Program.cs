/*
 * Programmer: Stephen Joy
 * Date: Winter 2021
 * Purpose: This program uses methods for better code reusability and readability purposes
 */

using System;
using static System.Console;

namespace WeightedAverageCalc
{
    class WAC
    {
        static void Main(string[] args)
        {
            // constant weights are defined here
            const float ASSIGNMENTS_PERCENTAGE = 0.2f;
            const float MIDTERM_EXAM_PERCENTAGE = 0.3f;
            const float QUIZ_PERCENTAGE = 0.1f;
            const float FINAL_EXAM_PERCENTAGE = 0.3f;

            // variables for storing the grades of a student
            float assignments;
            float midtermExam;
            float quiz1;
            float quiz2;
            float finalExam;

            float weightedExams = 0;
            float totalWeightedAverage = 0;


            Title = "CSIS1175 - Assignment 3 - By Stephen Joy";

            DisplayBanner("Total Weighted Average Calculator");

            // The user enters the grades, the program gets them and stores them in the corresponding variable
            assignments = GetUserInput("Assignments");
            midtermExam= GetUserInput("Midterm Exam");
            quiz1 = GetUserInput("Quiz1");
            quiz2 = GetUserInput("Quiz2");
            finalExam = GetUserInput("Final Exam");

            WriteLine("\n");

            // Total Weighted Avergae is sum of products of grades and their weight
            totalWeightedAverage += WeightedGrade(assignments, ASSIGNMENTS_PERCENTAGE);
            totalWeightedAverage += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
            totalWeightedAverage += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
            totalWeightedAverage += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);

            DisplayTableRow("Assessment", "Percentage", "Your Grade");
            DisplayTableRow("--------------", " -----------", "----------");

            DisplayTableRow("Assignments", ASSIGNMENTS_PERCENTAGE, assignments);
            DisplayTableRow("MidTerm Exam", MIDTERM_EXAM_PERCENTAGE, midtermExam);
            DisplayTableRow("Quiz1", QUIZ_PERCENTAGE, quiz1);
            DisplayTableRow("Quiz2", QUIZ_PERCENTAGE, quiz2);
            DisplayTableRow("Final Exam", FINAL_EXAM_PERCENTAGE, finalExam);

            WriteLine("----------------------------------------");

            // change the following line of code such that the Floor value of totalWeightedAverage is displayed on Console
            DisplayTableRow("Weighted Total", 1, (float)Math.Floor(totalWeightedAverage)); //** Change only this line **//

            WriteLine("\n");

            weightedExams += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
            weightedExams += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
            weightedExams += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);
            weightedExams /= 0.8f;

            // change the following line of code such that the Ceiling value of weightedExams is displayed on Console
            WriteLine("The Weighted Average Total on Exams (Midterm, Quizzes, Final exam) is {0:F2}", Math.Ceiling(weightedExams)); //** Change only this line **//
            WriteLine("If WAT-on-Exams is less than 50, the student fails the course.");

            ReadKey();
        }  
        
        //  your method definitions are written here (out of Main method). A method cannot be defined inside another method
        static void DisplayBanner(string banner)
        {
            Write("\\***************************************\\\n");
            Write("\\ \t\t\t\t\t\\\n");
            Write("\\  \"" + banner + "\"  \\\n");
            Write("\\ \t\t\t\t\t\\\n");
            Write("\\***************************************\\\n\n");
        }

        static float GetUserInput(string text)
        {
            string userValue;
            float parsedValue;

            Write("Enter a value for {0}: ", text);
            userValue = ReadLine();
            parsedValue = float.Parse(userValue);

            return parsedValue;
        }

        static float WeightedGrade(float value1, float value2)
        {
            float weightedGrade;

            weightedGrade = value1 * value2;

            return weightedGrade;
        }

        static void DisplayTableRow(string text1, string text2, string text3)
        {
            WriteLine("{0,14}{1,13}   {2,-1}", text1, text2, text3);
        }
        static void DisplayTableRow(string text, double value1, float value2)
        {
            WriteLine("{0,14}{1,13:p0}   {2,-15:F2}", text, value1, value2);
        }
    }
}
