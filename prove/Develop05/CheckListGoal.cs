public class CheckListGoal: Goal
{
    private int _amountCompleted, _target, _bonus;
    public CheckListGoal(string name, string description, string points, int target, int bonus): base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public void setAmount(int amount)
    {
        _amountCompleted = amount;
    }
    public override int RecordEvent()
    {
        int aux;

        _amountCompleted += 1;
        Console.WriteLine($"You win {GetPoints()} points");

        if (IsComplete()){
            Console.WriteLine($"You win {_bonus} points as bonus");
            aux = int.Parse(GetPoints()) + _bonus;
        } else {
            aux = int.Parse(GetPoints());
        }        

        return aux;
    }
    public override bool IsComplete()
    {
        bool aux = false;
        if (_amountCompleted == _target) {
            aux = true;
        } else {
            aux = false;
        }
        return aux;        
    }
    public override string GetDetailString()  // be overridden to shown the number of times the goal has been accomplished so far.
    {
        string detail = $"{GetGoalName()} ({GetDescription()}) - Currently completed {_amountCompleted}/{_target}";
        return detail;
    }
    public override string GetStringRepresentation()
    {
        string representation = $"CheckList Goal: {GetGoalName()}, {GetDescription()}, {GetPoints()}, {_bonus}, {_target}, {_amountCompleted}";
        return representation;
    }
}