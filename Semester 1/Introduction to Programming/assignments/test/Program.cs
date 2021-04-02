/* 
 * Student Name: Stephen Joy
 * Student ID: 300329148
 */

using System;
using System.IO;
using static System.Console;

namespace assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NO_OF_COURSES = 5;
            int lineNum = 1;

            Title = "CSIS1175 - Assignment 6 - By Stephen Joy";

            if (!File.Exists("../../../StudentData.txt"))
            {
                WriteLine("The file StudentData.txt does not exist");
            }
            else
            {
                StreamReader reader = new StreamReader("../../../StudentData.txt");
                WriteLine("The text file StudentData.txt opened for reading...");
                BinaryWriter writer = new BinaryWriter(new FileStream("../../../studentsGPA.dat", FileMode.Create));
                WriteLine("The binary file studentsGPA.dat opened for writing...\n");

                Student student = new Student(NO_OF_COURSES);

                while (!reader.EndOfStream)
                {
                    WriteLine($"Reading record {lineNum} ...  ");
                    string[] strArray = reader.ReadLine().Split(' ');
                    Student.Name = strArray[0];

                    int count = 0;

                    while (true)
                    {
                        if (count >= 5)
                        {
                            Student.GetGPA();
                            writer.Write(Student.Name);
                            writer.Write(Student.GPA);
                            Write("Writing to the binary file ...  ");
                            Write(Student.Name + " ");
                            WriteLine(Student.GPA);
                            WriteLine();
                            lineNum++;
                            break;
                        }
                        float.TryParse(strArray[count + 1], out Student.Grades[count]);
                        count++;
                    }
                }

                writer.Close();
                reader.Close();

                Write("\n\nPress a key to quit...");
                ReadKey();
            }
        }
    }
}
