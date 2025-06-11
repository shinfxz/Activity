using System;

public struct Time
{
    private readonly int minutes;

    public Time(int hh, int mm)
    {
        this.minutes = 60 * hh + mm;
    }

    public Time(int minutes)
    {
        this.minutes = minutes;
    }

    public int Hour => minutes / 60;
    public int Minute => minutes % 60;

    public override string ToString()
    {
        return String.Format("{0:D2}:{1:D2}", Hour, Minute);
    }

    public static implicit operator Time(int minutes)
    {
        return new Time(minutes);
    }

    public static explicit operator int(Time time)
    {
        return time.minutes;
    }
}
class Program
{
    static void Main()
    {
        Time time1 = new Time(10, 15);  
        Time time2 = 600;              

        int totalMinutes = (int)time1; 

        Console.WriteLine("Time 1: " + time1);
        Console.WriteLine("Time 2 (implicit conversion): " + time2);
        Console.WriteLine("Total minutes from Time 1: " + totalMinutes);
    }
}
