using System;

public class Film : Ljudspår
{
    public string Upplösning = "";

    public override string ToString()
    {
        return base.ToString() + " " + Upplösning;
    }
}


