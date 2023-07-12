using System.Runtime.InteropServices;

namespace Unity_Developer_Test_ThaiDucLoi
{
    public class Function
    {
        public bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            // optimize
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public void Print100FirstFibonacciNumbers()
        {
            int n = 100;
            ulong a = 0;
            ulong b = 1;

            Console.WriteLine("First 100 Fibonacci numbers:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a);

                ulong temp = a;
                a = b;
                b = temp + b;
            }
        }

        public string AddFractions(Fraction f1,Fraction f2)
        {
            int numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
            int denominator = f1.Denominator * f2.Denominator;
            Fraction f = new Fraction();
            f.Numerator = numerator; 
            f.Denominator = denominator;
            return f.ToString();
        }

        public Position CalculatePosition(float v, float a, float t)
        {
            float radians = (float)(a * Math.PI / 180);

            float x = (float)(v * Math.Cos(radians) * t);
            float y = (float)(v * Math.Sin(radians) * t);
            return new Position(x, y);
        }
    }
}
