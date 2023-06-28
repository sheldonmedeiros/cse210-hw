using System;
using System.Collections.Generic;

class Goal
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public int Value { get; set; }

    public virtual void Complete()
    {
        IsCompleted = true;
    }

    public static implicit operator Goal(EternalQuest v)
    {
        throw new NotImplementedException();
    }
}