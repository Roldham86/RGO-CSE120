using System;
using System.Collections.Generic;
using System.IO;
//W00F
public class EternalGoal : Goal
{
    public EternalGoal(string description, int points)
    {
        Description = description;
        Points = points;
    }

    public override bool IsComplete() => false;

    public override void RecordProgress()
    {
        // no use for this goal type
    }
}
