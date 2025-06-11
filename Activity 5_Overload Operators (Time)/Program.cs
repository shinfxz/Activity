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
    public static Time operator +(Time t1, Time t2)
    {
        return new Time(t1.minutes + t2.minutes);
    }
    public static Time operator -(Time t1, Time t2)
    {
        return new Time(Math.Max(0, t1.minutes - t2.minutes));
    }
}
class Program
{
    static void Main()
    {
        Time time1 = new Time(10, 30); 
        Time time2 = new Time(1, 45);  

        Console.WriteLine("Time 1: " + time1);
        Console.WriteLine("Time 2: " + time2);
  
    }
}
