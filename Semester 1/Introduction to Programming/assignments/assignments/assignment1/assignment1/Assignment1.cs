/*
 * Programmer:  Saeed Mirjalili
 * Date:        Fall 2020
 * Purpose:     Learning how to work with console
 */
using System;

namespace Assignment1
{
    class Assignment1
    {
        static void Main(string[] args)
        {
            // this program displays the following sentences and my initials (S M)
            Console.Title = "CSIS1175 - Assignment 1 - By Saeed Mirjalili";
            Console.WriteLine();
            Console.WriteLine("I am excited about writing my first program.");
            Console.WriteLine("I know \"Practice Makes Perfect\"");
            Console.WriteLine("\n");    // displays two blank lines: one blank line because of \n escape character and one because of WriteLine

            Console.Write("  /***** ");   Console.WriteLine("\t*         *");   // I wrote two statements in one line because it helps me to visualize my output easier. 
            Console.Write(" *       ");   Console.WriteLine("\t**       **");   // However it is not a good practice to write two statements in one line
            Console.Write("  \\****\\ "); Console.WriteLine("\t* *     * *");
            Console.Write("        * ");  Console.WriteLine("\t*  *   *  *");
            Console.Write("  *****/  ");  Console.WriteLine("\t*   * *   *");

            Console.Write("\n\n Press a key...");
            Console.ReadKey();
        }
    }
}
