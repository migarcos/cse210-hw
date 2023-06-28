using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test = new Assignment("Elena", "wdd230");
        test.GetSummary();
        Console.WriteLine($"{test.GetStudentName()} {test.GetTopic()}");

        MathAssignment task = new MathAssignment("Miguel","cse210","Inheritance","W03 Learning");
        task.GetSummary();
        task.GetHomeWorkList();
        Console.WriteLine($"{task.GetStudentName()} {task.GetTopic()} {task.GetTextbookSection()} {task.GetProblems()}");

        WritingAssignment task02 = new WritingAssignment("Catalina","cse110","W10 assignment");
        task02.GetSummary();
        task02.GetWritingInformation();
        Console.WriteLine($"{task02.GetStudentName()} {task02.GetTopic()} {task02.GetTitle()}");
        
        Console.WriteLine(" - - - - - - - - - - - - - - ");
        task.SetProblems("'Learning04 practice'");
        Console.WriteLine($"{task.GetStudentName()} -  {task.GetTopic()} : {task.GetTextbookSection()} {task.GetProblems()}");

        task02.SetTitle("'Define functions'");
        Console.WriteLine($"{task02.GetStudentName()} - {task02.GetTopic()} : {task02.GetTitle()}");
    }
}