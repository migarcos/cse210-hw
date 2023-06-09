using System;

class Program
{
    static void Main(string[] args)
    {
          Console.Write("Digit your average: ");
          int grade = int.Parse(Console.ReadLine());
          string finalGrade = " ";
          string last = " ";
          
          if (grade <= 100 && grade >= 0) {

               if (grade >= 90)
               {
                    finalGrade = "A";
               } 
               else if (grade >= 80) 
               {
                    finalGrade = "B";
               } 
               else if (grade >= 70) 
               {
                    finalGrade = "C";
               } 
               else if (grade >= 60) 
               {
                    finalGrade = "D";
               } 
               else {
                    finalGrade = "F";
               }      

               if (grade < 93 && grade > 61)
               {
                    if (grade % 10 > 6)
                    {
                         last = "+";
                    }
                    else if (grade % 10 < 4)
                    {
                         last = "-";
                    }
                    else 
                    {
                         last = " ";
                    }
               }
               
               Console.WriteLine($"Your final grade is {finalGrade}{last}");
          } 
          else 
          {
               Console.WriteLine($"Digited value is invalid");
          }
    }
}