public class SimpleGoal: Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, string points, bool complete = false): base(name, description, points)
    {
        _isComplete = complete;
    }
    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }
    public bool GetComplete()
    {
        return _isComplete;
    }
    public override int RecordEvent()
    {
        int aux;
        _isComplete = true;
        Console.WriteLine($"You win {GetPoints()} points");
        aux = int.Parse(GetPoints());

        return aux;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        string representation = $"Simple Goal: {GetGoalName()}, {GetDescription()}, {GetPoints()}, {_isComplete}";
        return representation;
    }
}