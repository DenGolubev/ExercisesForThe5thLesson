using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class ComplexNumber
    {
        public Complex complexNumber { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            complexNumber = new Complex(real, imaginary);
        }

        public static ComplexNumber operator +(ComplexNumber n1, ComplexNumber n2) //Сложение алгебраической форме
        {
            return new ComplexNumber(n1.complexNumber.Real + n2.complexNumber.Real, n1.complexNumber.Imaginary + n2.complexNumber.Imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber n1, ComplexNumber n2) // Вычитание по алгебраической форме
        {
            return new ComplexNumber(n1.complexNumber.Real - n2.complexNumber.Real, n1.complexNumber.Imaginary - n2.complexNumber.Imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber n1, ComplexNumber n2) //Умножение по алгебраической форме
        {
            var real = n1.complexNumber.Real * n2.complexNumber.Real - n1.complexNumber.Imaginary*n2.complexNumber.Imaginary;
            var imaginary = n1.complexNumber.Real * n2.complexNumber.Imaginary + n2.complexNumber.Real * n1.complexNumber.Imaginary;
            return new ComplexNumber(real, imaginary);
        }

        public static ComplexNumber operator /(ComplexNumber n1, ComplexNumber n2) // Деление по алгебраической форме
        {
            var real = (n1.complexNumber.Real * n2.complexNumber.Real + n1.complexNumber.Imaginary * n2.complexNumber.Imaginary) / 
                Math.Pow(n2.complexNumber.Real, 2) + Math.Pow(n2.complexNumber.Imaginary, 2) ;
            var imaginary = n2.complexNumber.Real * n1.complexNumber.Imaginary - n1.complexNumber.Real * n2.complexNumber.Imaginary /
                Math.Pow(n2.complexNumber.Real, 2) + Math.Pow(n2.complexNumber.Imaginary, 2);
            return new ComplexNumber(real, imaginary);
        }

        public override string ToString()
        {
            return $"Комплексное число - {complexNumber.Real} + {complexNumber.Imaginary}";
        }
    }
}
