public abstract class Goal
{
    private string _shortName, _description, _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public void SetName(string name)
    {
        _shortName = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void SetPoints(string points)
    {
        _points = points;
    }
    public string GetGoalName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public virtual string GetPoints()
    {
        return _points;
    }

    public abstract int RecordEvent();
    // This method should do whatever is necessary for each specific kind of goal, 
    // such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. 
    // It should return the point value associated with recording the event 
    // (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    public abstract bool IsComplete(); 
    // This method should return true if the goal is completed.
    //  The way you determine if a goal is complete is different for each type of goal.

    public virtual string GetDetailString()
    // return the details of a goal that could be shown in a list. 
    // It should include the checkbox, the short name, and description.
    {
        string detail = $"{_shortName} ({_description}) ";
        return detail;
    }
    public abstract string GetStringRepresentation();
    // This method should provide all of the details of a goal 
    // in a way that is easy to save to a file, and then load later

}