using System;
using System.Diagnostics;
using System.Numerics;
using System.Text.RegularExpressions;
using Unity_Developer_Test_ThaiDucLoi;

public class Program
{
    public static void Main(string[] args)
    {
        int number = 109;
        Stopwatch stopwatch = new Stopwatch();
        Function func= new Function();
        Fraction fraction1 = new Fraction("1/2");
        Fraction fraction2 = new Fraction("2/6");
        stopwatch.Start();
        //string result = func.AddFractions(fraction1, fraction2);
        float v = 20; // vận tốc đầu (m/s)
        float a = 45; // góc ném (độ)
        float t = 2; // thời điểm (s)

        Position pos = func.CalculatePosition(v, a, t);

        stopwatch.Stop();
        TimeSpan elapsedTime = stopwatch.Elapsed;
        Console.WriteLine($"Result: {pos.X}:{pos.Y}");
        //Console.WriteLine($"{number} is prime: {isPrime}");
        Console.WriteLine($"Elapsed time: {elapsedTime.TotalMilliseconds} milliseconds");
    }
}
