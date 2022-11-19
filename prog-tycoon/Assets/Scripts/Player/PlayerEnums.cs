public enum Job
{
    None,
    McDonald,
    PartTimeMcDonald,
    JuniorProgrammer,
    MidProgrammer,
}
public enum Seasons
{
    Spring,
    Summer,
    Autumn,
    Winter,
}
public enum Week
{
    Monday,
    Tuesday,
    Wenesday,
    Thursday,
    Friday,
    Saturday,
    Sunday,
}
public struct GameTime
{
    public int hours { get; set; }
    public int minutes { get; set; }
}

public struct GameCallendar
{
    public int days;
    public Week week;
    public Seasons seasons;
    public int years;
}