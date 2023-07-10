using System;

class Program
{
    static void Main(string[] args)
    {
        int usrMenuOpt = 0;

        List<string> menu = new List<string>
        {
            "MENU",
            "   1. Breathing activity",
            "   2. Reflecing activity",
            "   3. Listening activity",
            "   4. Quit"
        };

        

        while (usrMenuOpt != 4)
        {
            Console.Clear();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Choice an activity from the menu: ");
            usrMenuOpt = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (usrMenuOpt)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
            }
        }
    }

    // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
    static public void Roto() // a practice to develop spinner
    {   
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(10);

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        int i = 0;
        while (currentTime < futureTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            // Console.Write("\b \b");
            // Console.Write("|");
            // Thread.Sleep(200);
            // Console.Write("\b \b");
            // Console.Write("/");
            // Thread.Sleep(200);
            // Console.Write("\b \b");
            // Console.Write("-");
            // Thread.Sleep(200);
            // Console.Write("\b \b");
            // Console.Write("\\");
            // Thread.Sleep(200);
            currentTime = DateTime.Now;
            i++;
            if (i == 4){
                i = 0;
            }

        }
        Console.Write("\b \b");
        Console.WriteLine("finish");    
    }
    // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
}