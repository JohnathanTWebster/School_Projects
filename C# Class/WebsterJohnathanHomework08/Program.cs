using System;






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
    class Program
    {
        static void Main(string[] args)
        {
            //global containers
            string strValue = "";
            int totalreports = 3;

            Console.WriteLine();
            int numCount = 0;

            //Loop control
            for (int i = 0; i < totalreports; i++)
            {
                try //try for valid reports and display error if invalid input
                {
                    numCount++;
                    Console.WriteLine("Enter student name for report " + numCount + ": ");
                    string stdName = Console.ReadLine();
                    Console.Write("\n");
                Sub1:
                    Console.WriteLine("Enter " + stdName + "'s mid term grade : ");
                    strValue = Console.ReadLine();
                    int numGrade1;
                    if (!int.TryParse(strValue, out numGrade1))
                    {
                        Console.WriteLine("Please enter a numeric value.");
                        Console.Write("\n");
                        goto Sub1;
                    }

                    Console.Write("\n");
                Sub2:
                    Console.WriteLine("Enter " + stdName + "'s final exam grade : ");
                    strValue = Console.ReadLine();
                    int numGrade2;
                    if (!int.TryParse(strValue, out numGrade2))
                    {
                        Console.WriteLine("Please enter a numeric value.");
                        Console.Write("\n");
                        goto Sub2;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Report card for " + stdName + " : ");
                    ReportCard objRpt = new ReportCard(stdName, numGrade1, numGrade2);
                    Console.WriteLine(objRpt);
                    Console.WriteLine("-----------------------------------");
                    Console.Write("\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
