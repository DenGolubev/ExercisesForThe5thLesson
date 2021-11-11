using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class RationalNumber
    {
        double numerator => Numerator;
        double denominator => Denominator;

        public double Numerator { get; }
        public double Denominator { get; }
        public RationalNumber(double numerator, double denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static bool operator !=(RationalNumber n1, RationalNumber n2)
        {
            return !n1.Equals(n2);
        }

        public static bool operator ==(RationalNumber n1, RationalNumber n2)
        {
            return n1.Equals(n2);
        }

        public static int operator >(RationalNumber n1, RationalNumber n2)
        {
            return n1.Equals(n2).CompareTo(n2);
        }

        public static int operator <(RationalNumber n1, RationalNumber n2)
        {
            return n1.Equals(n2).CompareTo(n2);
        }

        public static int operator >=(RationalNumber n1, RationalNumber n2)
        {
            return n1.Equals(n2).CompareTo(n2);
        }

        public static int operator <=(RationalNumber n1, RationalNumber n2)
        {
            return n1.Equals(n2).CompareTo(n2);
        }

        public static RationalNumber operator +(RationalNumber n1, RationalNumber n2)
        {
            return new RationalNumber(n1.numerator + n2.numerator, n1.denominator + n2.denominator);
        }

        public static RationalNumber operator -(RationalNumber n1, RationalNumber n2)
        {
            return new RationalNumber(n1.numerator - n2.numerator, n1.denominator - n2.denominator);
        }

        public static RationalNumber operator *(RationalNumber n1, RationalNumber n2)
        {
            return new RationalNumber(n1.numerator * n2.numerator, n1.denominator * n2.denominator);
        }

        public static RationalNumber operator /(RationalNumber n1, RationalNumber n2)
        {
            return new RationalNumber(n1.numerator / n2.numerator, n1.denominator / n2.denominator);
        }

        public static RationalNumber operator ++(RationalNumber n1)
        {
            return new RationalNumber(n1.numerator + 1, n1.denominator + 1);
        }

        public static RationalNumber operator --(RationalNumber n1)
        {
            return new RationalNumber(n1.numerator - 1, n1.denominator - 1);
        }

        public static RationalNumber operator %(RationalNumber n1, RationalNumber n2)
        {
            return new RationalNumber(n1.numerator - (n1.numerator / n2.numerator) * n2.denominator, n1.denominator - (n1.denominator / n2.denominator) * n2.denominator);
        }

        public static implicit operator float(RationalNumber n1)
        {
            var x = new RationalNumber(n1.numerator, n1.denominator);
            return (float)x.numerator;
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{this.numerator} / {this.denominator}";
        }
    }
}
