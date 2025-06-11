using System;

public struct Time
{
    private readonly int minutes;
    public Time(int hh, int mm)
    {
        this.minutes = 60 * hh + mm;
    }
    public int Hour => minutes / 60;
    public int Minute => minutes % 60;

    public override string ToString()
    {
        return String.Format("{0:D2}:{1:D2}", Hour, Minute);
    }
}
class Program
{
    static void Main()
    {
        Time time1 = new Time(9, 50);
        Time time2 = new Time(7, 05);
        Time time3 = new Time(23, 45);

        Console.WriteLine("Time 1: " + time1);
        Console.WriteLine("Time 2: " + time2);
        Console.WriteLine("Time 3: " + time3);
    }
}
