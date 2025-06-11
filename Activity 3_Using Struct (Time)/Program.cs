using System;

public struct Time {
    private readonly int minutes;
    public Time(int hh, int mm) {
        this.minutes = 60 * hh + mm;
    }
    public override string ToString()
    {
        return minutes.ToString();
    }
}
class Program {
    static void Main() {
        Time time1 = new Time(9, 50);   
        Time time2 = new Time(7, 05);  

        Console.WriteLine("Morning time: " + time1);
        Console.WriteLine("Midnight time: " + time2);
    }
}
