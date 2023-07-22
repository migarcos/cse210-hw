public class EternalGoal: Goal
{
    public EternalGoal(string name, string description, string points): base(name, description, points)
    {
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override int  RecordEvent()
    {
        int aux;
        Console.WriteLine($"You win {GetPoints()} points");

        aux = int.Parse(GetPoints());

        return aux;
    }
    public override string GetStringRepresentation()
    {
        string representation = $"Eternal Goal: {GetGoalName()}, {GetDescription()}, {GetPoints()}";
        return representation;
    }
}

