using System.Diagnostics;
public class Activity
{
    private string _activityName, _description;
    static int _duration, _spinnerCounter;

    public Activity()
    {
        _duration = _spinnerCounter = 0;
    }
    public Activity(string name, string description, int duration = 0)
    {
        _activityName = name;
        _description = description;
        _duration = duration;
        _spinnerCounter = 0;
    }
    // Getters and Setters
    public void SetActivityName(string name)
    {
        _activityName = name;
    }
    public void SetActivityDescription(string description)
    {
        _description = description;
    }
    public void SetactivityDuration(int duration)
    {
        _duration = duration;
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetActivityDescription()
    {
        return _description;
    }
    public int GetActivityDuration()
    {
        return _duration;
    }
    // Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"welcome to the {_activityName}\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready... ");
        ShowSpinner(2);
    }
    
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have been completed another {_duration} seconds of {_activityName} ");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < seconds)
        {
            _spinnerCounter++;
            switch (_spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop);
            Thread.Sleep(250);
        }
        Console.Write(" ");
    }

    public void ShowCountDown(int times, int speed = 1000)
    {
        if (speed < 1000) {
            times = times * 1000 / speed;
        }
        
        for (int i = times; i >= 1; i--)
        {            
            if (i > 9) 
            {
                Console.Write(string.Format("{0}", i));
                Console.SetCursorPosition(Console.CursorLeft -2, Console.CursorTop);
            } else {
                if (i == 9) {Console.Write(" ");}
                Console.Write(string.Format("{0}", i));
                Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop);                
            }            
            Thread.Sleep(speed);
        }
        Console.WriteLine(" ");
    }

    public List<string> ReorderList(List<string> toRandomize) 
    {
        Random random = new Random();

        for (int i = toRandomize.Count -1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            string temp = toRandomize[i];
            toRandomize[i] = toRandomize[j];
            toRandomize[j] = temp;
        }
        return toRandomize;
    }
}