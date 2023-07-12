using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Unity_Developer_Test_ThaiDucLoi
{
    public class Fraction
    {
        private int numerator;
        private int denominator;
        
        public Fraction() { }

        public Fraction(string fraction)
        {
            string pattern = @"(\d+)/(\d+)";
            Match match = Regex.Match(fraction, pattern);
            this.numerator = int.Parse(match.Groups[1].Value);
            this.denominator = int.Parse(match.Groups[2].Value);
        }

        public int Numerator { get => numerator; set => numerator = value; }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value != 0)
                {
                    denominator = value;
                }
                else
                {
                    throw new ArgumentException("Denominator cannot be zero.");
                }
            }
        }

        private void SimplifyFraction()
        {
            int gcd = GreatestCommonDivisor(this.numerator, this.denominator);
            this.numerator /= gcd;
            this.denominator /= gcd;
        }
        private int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            SimplifyFraction();
            if(this.numerator.Equals(this.denominator))
            {
                return 1.ToString();
            }
            return this.numerator + "/" + this.denominator;
        }
    }
}
