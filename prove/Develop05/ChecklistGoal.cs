public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _count = 0;
    }

    public override int RecordEvent()
    {
        _count++;

        if (_count == _target)
        {
            _isComplete = true;
            return _points + _bonus;
        }

        return _points;
    }

    public override string GetDetails()
    {
        return $"{GetStatus()} {_name} ({_description}) -- Completed {_count}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_bonus},{_target},{_count}";
    }
}