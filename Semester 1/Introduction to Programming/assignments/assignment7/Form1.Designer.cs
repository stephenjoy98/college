
namespace assignment7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quiz = new System.Windows.Forms.Label();
            this.assignment = new System.Windows.Forms.Label();
            this.midterm = new System.Windows.Forms.Label();
            this.final = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.Label();
            this.quizWeight = new System.Windows.Forms.TextBox();
            this.assignmentWeight = new System.Windows.Forms.TextBox();
            this.midtermWeight = new System.Windows.Forms.TextBox();
            this.finalsWeight = new System.Windows.Forms.TextBox();
            this.quizGrade = new System.Windows.Forms.TextBox();
            this.assignmentGrade = new System.Windows.Forms.TextBox();
            this.midtermGrade = new System.Windows.Forms.TextBox();
            this.finalsGrade = new System.Windows.Forms.TextBox();
            this.grade2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.calculatedWeight = new System.Windows.Forms.Label();
            this.calculatedGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quiz
            // 
            this.quiz.AutoSize = true;
            this.quiz.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quiz.Location = new System.Drawing.Point(124, 85);
            this.quiz.Name = "quiz";
            this.quiz.Size = new System.Drawing.Size(70, 23);
            this.quiz.TabIndex = 0;
            this.quiz.Text = "Quizzes";
            // 
            // assignment
            // 
            this.assignment.AutoSize = true;
            this.assignment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.assignment.Location = new System.Drawing.Point(83, 143);
            this.assignment.Name = "assignment";
            this.assignment.Size = new System.Drawing.Size(111, 23);
            this.assignment.TabIndex = 1;
            this.assignment.Text = "Assignments";
            // 
            // midterm
            // 
            this.midterm.AutoSize = true;
            this.midterm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.midterm.Location = new System.Drawing.Point(65, 203);
            this.midterm.Name = "midterm";
            this.midterm.Size = new System.Drawing.Size(129, 23);
            this.midterm.TabIndex = 2;
            this.midterm.Text = "Midterm Exam";
            // 
            // final
            // 
            this.final.AutoSize = true;
            this.final.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.final.Location = new System.Drawing.Point(98, 262);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(96, 23);
            this.final.TabIndex = 3;
            this.final.Text = "Final Exam";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.weight.Location = new System.Drawing.Point(238, 48);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(69, 23);
            this.weight.TabIndex = 4;
            this.weight.Text = "Weight";
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grade.Location = new System.Drawing.Point(338, 48);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(58, 23);
            this.grade.TabIndex = 5;
            this.grade.Text = "Grade";
            // 
            // quizWeight
            // 
            this.quizWeight.Location = new System.Drawing.Point(200, 89);
            this.quizWeight.Name = "quizWeight";
            this.quizWeight.Size = new System.Drawing.Size(107, 27);
            this.quizWeight.TabIndex = 1;
            // 
            // assignmentWeight
            // 
            this.assignmentWeight.Location = new System.Drawing.Point(200, 144);
            this.assignmentWeight.Name = "assignmentWeight";
            this.assignmentWeight.Size = new System.Drawing.Size(107, 27);
            this.assignmentWeight.TabIndex = 3;
            // 
            // midtermWeight
            // 
            this.midtermWeight.Location = new System.Drawing.Point(200, 203);
            this.midtermWeight.Name = "midtermWeight";
            this.midtermWeight.Size = new System.Drawing.Size(107, 27);
            this.midtermWeight.TabIndex = 5;
            // 
            // finalsWeight
            // 
            this.finalsWeight.Location = new System.Drawing.Point(200, 262);
            this.finalsWeight.Name = "finalsWeight";
            this.finalsWeight.Size = new System.Drawing.Size(107, 27);
            this.finalsWeight.TabIndex = 7;
            // 
            // quizGrade
            // 
            this.quizGrade.Location = new System.Drawing.Point(338, 89);
            this.quizGrade.Name = "quizGrade";
            this.quizGrade.Size = new System.Drawing.Size(125, 27);
            this.quizGrade.TabIndex = 2;
            // 
            // assignmentGrade
            // 
            this.assignmentGrade.Location = new System.Drawing.Point(338, 143);
            this.assignmentGrade.Name = "assignmentGrade";
            this.assignmentGrade.Size = new System.Drawing.Size(125, 27);
            this.assignmentGrade.TabIndex = 4;
            // 
            // midtermGrade
            // 
            this.midtermGrade.Location = new System.Drawing.Point(338, 203);
            this.midtermGrade.Name = "midtermGrade";
            this.midtermGrade.Size = new System.Drawing.Size(125, 27);
            this.midtermGrade.TabIndex = 6;
            // 
            // finalsGrade
            // 
            this.finalsGrade.Location = new System.Drawing.Point(338, 262);
            this.finalsGrade.Name = "finalsGrade";
            this.finalsGrade.Size = new System.Drawing.Size(125, 27);
            this.finalsGrade.TabIndex = 8;
            // 
            // grade2
            // 
            this.grade2.AutoSize = true;
            this.grade2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grade2.Location = new System.Drawing.Point(469, 318);
            this.grade2.Name = "grade2";
            this.grade2.Size = new System.Drawing.Size(101, 23);
            this.grade2.TabIndex = 14;
            this.grade2.Text = "Final Grade";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Calculate Weighted Average";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calculatedWeight
            // 
            this.calculatedWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedWeight.Location = new System.Drawing.Point(200, 315);
            this.calculatedWeight.Name = "calculatedWeight";
            this.calculatedWeight.Size = new System.Drawing.Size(107, 26);
            this.calculatedWeight.TabIndex = 18;
            // 
            // calculatedGrade
            // 
            this.calculatedGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedGrade.Location = new System.Drawing.Point(338, 315);
            this.calculatedGrade.Name = "calculatedGrade";
            this.calculatedGrade.Size = new System.Drawing.Size(125, 26);
            this.calculatedGrade.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(672, 557);
            this.Controls.Add(this.calculatedGrade);
            this.Controls.Add(this.calculatedWeight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grade2);
            this.Controls.Add(this.finalsGrade);
            this.Controls.Add(this.midtermGrade);
            this.Controls.Add(this.assignmentGrade);
            this.Controls.Add(this.quizGrade);
            this.Controls.Add(this.finalsWeight);
            this.Controls.Add(this.midtermWeight);
            this.Controls.Add(this.assignmentWeight);
            this.Controls.Add(this.quizWeight);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.final);
            this.Controls.Add(this.midterm);
            this.Controls.Add(this.assignment);
            this.Controls.Add(this.quiz);
            this.Name = "Form1";
            this.Text = "Assignment 7 by Stephen Joy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quiz;
        private System.Windows.Forms.Label assignment;
        private System.Windows.Forms.Label midterm;
        private System.Windows.Forms.Label final;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.TextBox quizWeight;
        private System.Windows.Forms.TextBox assignmentWeight;
        private System.Windows.Forms.TextBox midtermWeight;
        private System.Windows.Forms.TextBox finalsWeight;
        private System.Windows.Forms.TextBox quizGrade;
        private System.Windows.Forms.TextBox assignmentGrade;
        private System.Windows.Forms.TextBox midtermGrade;
        private System.Windows.Forms.TextBox finalsGrade;
        private System.Windows.Forms.Label grade2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label calculatedWeight;
        private System.Windows.Forms.Label calculatedGrade;
    }
}

