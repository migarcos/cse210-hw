using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "IBM";
        job1._jobTitle = "junior programmer";
        job1._startYear = 2000;
        job1._endYear = 2010;

        // job1.Display();

        Job job2 = new Job();

        job2._company = "Microsoft";
        job2._jobTitle = "Software Architect";
        job2._startYear = 2011;
        job2._endYear = 2020;

        // job2.Display();
        Resume myResume = new Resume();
        myResume._personName = "Miguel Arcos";
        myResume._jobs.Add(job1);
        Console.WriteLine(myResume._jobs[0]._jobTitle);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}