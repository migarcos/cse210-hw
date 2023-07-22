using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        GoalManager mngrGoal = new GoalManager();        

        string usrOption = "";
        while (usrOption != "6")
        { 
            //Simple: Give a talk // Speak in a sacrament meeting when asked  // 100
            //Eternal: Study the scriptures // Study for at least 10 minutes // 50
            //CheckList: Attend the temple // Attend and perform any ordinance // 50   // time 3  
            //CheckList: Wake up early  // Wake up at least 6 a.m.  // 10 // times 10

            MainMenu();
            Console.Write("Select a choice from the menu: ");
            usrOption = Console.ReadLine();

            switch (usrOption)
            {
                case "1":
                    mngrGoal.CreateGoal();
                    break;
                case "2":
                    mngrGoal.ListGoalDetail();
                    break;
                case "3":
                    mngrGoal.SaveGoals();
                    break;
                case "4":
                    mngrGoal.LoadGoals();
                    break;
                case "5":
                    mngrGoal.RecordEvent();
                    break;
            }
        } 

        Console.WriteLine("\nSee you the next time.");       
    }

    static public void MainMenu()
    {
        List<string> mainMenu = new List<string>() {"Menu Options", 
            "   1. Create New Goal",
            "   2. List Goals",
            "   3. Save Goals",
            "   4. Load Goals",
            "   5. Record Event",
            "   6. Quit"            
        };

        foreach (string line in mainMenu)
        {
            Console.WriteLine(line);
        }
    }

}