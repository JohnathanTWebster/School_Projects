using System;
using System.Collections.Generic;
using System.Text;

//Create a program as a Console Application that attempts to create several valid and invalid ReportCard objects.
//Immediately after each instantiation attempt, handle any thrown exceptions by displaying an error message. 
//Create a ReportCard class with four fields for a student name, a numeric midterm grade, a numeric final exam grade, and letter grade.
//The ReportCard constructor requires values for the name and two numeric grades and determines the letter grade.
//Upon construction, throw an ArgumentException if the midterm or final exam grade is less than 0 or more than 100.
//The letter grade is based on the arithmetic average of the midterm and final exams using a grading scale
//of A for an average of 90 to 100, B for 80 to 90, C for 70 to 80, D for 60 to 70, and F for an average below 60.
//Display all the data if the instantiation is successful.

namespace WebsterJohnathanHomework08
{
    class ReportCard
    {
        private string studentName;
        private int midTermGrade;
        private int finalExamGrade;
        private char grade;

        public ReportCard(string name, int midtermgrade, int finalgrade)
        {
            //Validate if the numbers entered are valid entries
            if (midtermgrade < 0 || midtermgrade > 100 || finalgrade < 0 || finalgrade > 100)
            {
                //if they are not valid advise user what needs to be entered
                throw new ArgumentException(name + " midterm and final exam grades must be between 0 and 100");
            }
            else
            {
                //if successful then assign the entered values
                this.studentName = name;
                this.midTermGrade = midtermgrade;
                this.finalExamGrade = finalgrade;
            }

            //calculate the average
            int averageGrade = (midtermgrade + finalgrade) / 2;

            //assign the grade average grade
            if (averageGrade >= 90 && averageGrade <= 100)
            {
                grade = 'A';
            }
            else if (averageGrade >= 80 && averageGrade < 90)
            {
                grade = 'B';
            }
            else if (averageGrade >= 70 && averageGrade < 80)
            {
                grade = 'C';
            }
            else if (averageGrade >= 60 && averageGrade < 70)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }
        }

        //display the results of the entered values
        public override string ToString()
        {
            return "Student Name = " + studentName + "\nMid Term Grade= " + midTermGrade + "\nFinal Exam Grade= "
            + finalExamGrade + "\nGrade= " + grade;

        }
    }
}
