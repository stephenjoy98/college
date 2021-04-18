/* Name: Stephen Joy 
 * ID: 300329148
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            quizWeight.Text = (0.2).ToString();
            assignmentWeight.Text = (0.15).ToString();
            midtermWeight.Text = (0.3).ToString();
            finalsWeight.Text = (0.35).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float[,] studentGrades = new float[4, 2];
            bool flag = false;
            float totalWeight = 0;
            float finalGrade = 0;

            if ((!float.TryParse(quizWeight.Text, out studentGrades[0,0]))||(studentGrades[0,0] > 1) || (studentGrades[0, 0] < 0))
            {
                MessageBox.Show("Enter a number between 0 and 1 for Quizzes Weight");
                flag = true;
            }
            else if ((!float.TryParse(assignmentWeight.Text, out studentGrades[1, 0])) || (studentGrades[1, 0] > 1) || (studentGrades[1, 0] < 0))
            {
                MessageBox.Show("Enter a number between 0 and 1 for Assignments Weight");
                flag = true;
            }
            else if ((!float.TryParse(midtermWeight.Text, out studentGrades[2, 0])) || (studentGrades[2, 0] > 1) || (studentGrades[2, 0] < 0))
            {
                MessageBox.Show("Enter a number between 0 and 1 for Midterm Weight");
                flag = true;
            }
            else if ((!float.TryParse(finalsWeight.Text, out studentGrades[3, 0])) || (studentGrades[3, 0] > 1) || (studentGrades[3, 0] < 0))
            {
                MessageBox.Show("Enter a number between 0 and 1 for Midterm Weight");
                flag = true;
            }
            else if ((!float.TryParse(quizGrade.Text, out studentGrades[0, 1])) || (studentGrades[0, 1] > 100) || (studentGrades[0, 1] < 0))
            {
                MessageBox.Show("Enter a number between 0 and 100 for Quizzes Grade");
                flag = true;
            }
            else if ((!float.TryParse(assignmentGrade.Text, out studentGrades[1, 1])) || (studentGrades[1, 1] > 100) || (studentGrades[1, 1] < 0))
            {
                MessageBox.Show("Enter a number between 0 and 100 for Asssignments Grade");
                flag = true;
            }
            else if ((!float.TryParse(midtermGrade.Text, out studentGrades[2, 1])) || (studentGrades[2, 1] > 100) || (studentGrades[2, 1] < 0))
            {
                MessageBox.Show("Enter a number between 0 and 100 for Midterm Grade");
                flag = true;
            }
            else if ((!float.TryParse(finalsGrade.Text, out studentGrades[3, 1])) || (studentGrades[3, 1] > 100) || (studentGrades[3, 1] < 0))
            {
                MessageBox.Show("Enter a number between 0 and 100 for Finals Grade");
                flag = true;
            }

            if (!flag)
            {
                for (int i = 0; i < 4; i++)
                {
                    totalWeight += studentGrades[i, 0];
                    finalGrade += studentGrades[i, 0] * studentGrades[i, 1];
                }

                calculatedWeight.Text = (totalWeight * 100).ToString();
                calculatedGrade.Text = finalGrade.ToString();

            }
        }
    }
}
