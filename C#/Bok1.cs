using System;

public class Media
{
    public string Titel = "";

    public override string ToString()
    {
        return Titel; 
    }
}


public class Bok : Media
{
    public int AntalSidor = 0;

    public override string ToString()
    {
        return Titel + ": " + AntalSidor + " sidor";
    }
}

public class Ljudspår : Media
{
    public double SpelTid = 0;

    public override string ToString()
    {
        return Titel + ": " + SpelTid + " minuter";
    }
}

public class Film : Ljudspår
{
    public string Upplösning = "";

    public override string ToString()
    {
        return base.ToString() + " " + Upplösning;
    }
}

