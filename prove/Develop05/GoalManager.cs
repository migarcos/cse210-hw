using System.IO; 

public class GoalManager
{
    private     List<Goal>  _goals = new List<Goal>();
    private     int         _score;
    public GoalManager()
    {
        _score = 0;
    }
    //This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    public void Start() 
    {
    }
    public void DisplayPlayerInfo() // Displays the players current score.
    {

    }

    // Lists the details of each goal (including the checkbox of whether it is complete).
    public void ListGoalDetail() 
    {   
        bool complete;
        string state;        
        int i = 0;

        Console.WriteLine($"\nThe goals are:");
        foreach (Goal goal in _goals)
        {
            complete = goal.IsComplete();
            if (complete)
            {
                state = "X";
            } else {
                state = " ";
            }

            i++;
            Console.WriteLine($"{i}. [{state}] {goal.GetDetailString()}");
        }
        Console.WriteLine($"\nYour actual score: {_score}");
    }
    public void ListGoalNames() // Lists the names of each of the goals.
    {
        int i = 1;
        Console.WriteLine();
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetGoalName()}");
            i += 1;
        }
    }
    public void CreateGoal() // *Functional*
    // Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    {
        Console.WriteLine("\nThe types of goals are: \n"+
            "   1. Simple Goal\n"+
            "   2. Eternal Goal\n"+
            "   3. Checklist Goal"
            );  
        Console.Write("\nWich type of goal would you like to create?: ");
        int usrGoal = int.Parse(Console.ReadLine());
        string name, description, points;
        int target, bonus;

        switch (usrGoal)
        {
            case 1:
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of point associated whit this goal: ");
                points = Console.ReadLine();
                SimpleGoal goalSimple = new SimpleGoal(name, description, points, false);
                _goals.Add(goalSimple);
                break;
            case 2:
                Console.Write("What is the name of your goal ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it ");
                description = Console.ReadLine();
                Console.Write("What is the amount of point associated whit this goal: ");
                points = Console.ReadLine();
                EternalGoal goalEternal = new EternalGoal(name, description, points);
                _goals.Add(goalEternal);
                break;
            case 3:
                Console.Write("What is the name of your goal ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it ");
                description = Console.ReadLine();
                Console.Write("What is the amount of point associated whit this goal: ");
                points = Console.ReadLine();
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus to accomplish it that many times? ");
                bonus = int.Parse(Console.ReadLine());
                CheckListGoal goalCheckList = new CheckListGoal(name, description, points, target, bonus);
                _goals.Add(goalCheckList);
                break;
        }

    }
    public void RecordEvent()
    // Asks the user which goal they have done and then records the event by calling 
    // the RecordEvent method on that goal.
    {
        ListGoalNames();
        Console.Write("Wich goal did you accomplish? "); 
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        _score += _goals[goalIndex].RecordEvent();

        Console.WriteLine($"You have {_score} points");
    }
    public void SaveGoals()     // *Functional* Saves the list of goals to a file.
    {
        string filename = "goals.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }    
        }
        Console.WriteLine("The goals was saved!");
    }
    public void LoadGoals()    // *Functional* Loads the list of goals from a file.
    {
        string filename = "goals.txt";
        string[] rows = System.IO.File.ReadAllLines(filename);

        int numRows = rows.Count();

        int score = int.Parse(File.ReadLines(filename).FirstOrDefault());
        Console.WriteLine($"Actual score: {score}");

        foreach(string row in rows.Skip(1))
        {
            string[] elements = row.Split(":");

            string goalType = elements[0];
            string goalData = elements[1];

            if (goalType == "Simple Goal")
            {                
                string[] atributes = goalData.Split(",");

                string goalName = atributes[0];
                string goalDescr = atributes[1];
                string goalPoints = atributes[2];
                string isComplete =  atributes[3];
                bool complete;
                if (isComplete == "False") {
                    complete = false;
                } else {
                    complete = true;
                }

                SimpleGoal loadGoal1 = new SimpleGoal(goalName, goalDescr, goalPoints, complete);                
                _goals.Add(loadGoal1);
            } 
            else if (goalType == "Eternal Goal")
            {                
                string[] atributes = goalData.Split(",");

                string goalName = atributes[0];
                string goalDescr = atributes[1];
                string goalPoints = atributes[2];
                
                EternalGoal loadGoal2 = new EternalGoal(goalName, goalDescr, goalPoints);
                _goals.Add(loadGoal2);

            } else {                
                string[] atributes = goalData.Split(",");

                string goalName = atributes[0];
                string goalDescr = atributes[1];
                string goalPoints = atributes[2];
                int target =  int.Parse(atributes[4]);
                int bonus = int.Parse(atributes[3]);
                int amount = int.Parse(atributes[5]);

                CheckListGoal loadGoal3 = new CheckListGoal(goalName, goalDescr, goalPoints, target, bonus);                
                loadGoal3.setAmount(amount);

                _goals.Add(loadGoal3);
            }
        }
        
        Console.WriteLine("File readed succesfully! ");
    }

}