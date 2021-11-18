﻿namespace Lesson3
{
    /// <summary>
    /// Represents a complex number.
    /// </summary>
    internal class ComplexClass
    {
        private double realPart;
        public double RealPart
        {
            get
            {
                return realPart;
            }
            set
            {
                realPart = value;
            }
        }

        private double imaginaryPart;
        public double ImaginaryPart
        {
            get
            {
                return imaginaryPart;
            }
            set
            {
                imaginaryPart = value;
            }
        }

        /// <summary>
        /// Constructor of a complex number.
        /// </summary>
        /// <param name="realPart">Real part of a complex number.</param>
        /// <param name="imaginaryPart">Imaginary part of a complex number.</param>
        public ComplexClass(double realPart, double imaginaryPart)
        {
            this.realPart = realPart;
            this.imaginaryPart = imaginaryPart;
        }

        /// <summary>
        /// Overloading of the + operatop, the sum of complex numbers.
        /// </summary>
        /// <param name="complex1">Complex number.</param>
        /// <param name="complex2">Complex number.</param>
        /// <returns>The sum of complex numbers.</returns>
        public static ComplexClass operator +(ComplexClass complex1, ComplexClass complex2)
        {
            return new ComplexClass(complex1.RealPart + complex2.RealPart, complex1.ImaginaryPart + complex2.ImaginaryPart);
        }

        /// <summary>
        /// Overloading of the - operatop, the difference of complex numbers.
        /// </summary>
        /// <param name="complex1">Complex number.</param>
        /// <param name="complex2">Complex number.</param>
        /// <returns>The difference of complex numbers.</returns>
        public static ComplexClass operator -(ComplexClass complex1, ComplexClass complex2)
        {
            return new ComplexClass(complex1.RealPart - complex2.RealPart, complex1.ImaginaryPart - complex2.ImaginaryPart);
        }

        public override string ToString()
        {
            return $"{realPart}+{imaginaryPart}i";
        }
    }
}