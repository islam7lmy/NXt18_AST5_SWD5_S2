using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OperatorOverLoading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        private Complex()
        {

        }

        public Complex(int real, int imag)
        {
            Real = real;
            Imag = imag;
        }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        ///operator overloading
        public static Complex operator +(Complex a, Complex b)
        {
            //Complex c = new Complex(a.Real + b.Real, a.Imag + b.Imag);
            //return c;
            //return new Complex((a?.Real ?? 0) + (b?.Real ?? 0), (a?.Imag ?? 0) + (b?.Imag ?? 0));

            return new Complex()
            {
                Real = (a?.Real ?? 0) + (b?.Real ?? 0),
                Imag = (a?.Imag ?? 0) + (b?.Imag ?? 0)
            };
        }

        /// -
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) - (b?.Real ?? 0),
                Imag = (a?.Imag ?? 0) - (b?.Imag ?? 0)
            };
        }

        /// ++
        public static Complex operator ++(Complex a)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) + 1,
                Imag = (a?.Imag ?? 0) + 1
            };
        }

        /// --
        public static Complex operator --(Complex a)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) - 1,
                Imag = (a?.Imag ?? 0) - 1
            };
        }

        /// >
        public static bool operator >(Complex a, Complex b)
        {
            if ((a?.Real ?? 0) == (b?.Real ?? 0))
                return (a?.Imag ?? 0) > (b?.Imag ?? 0);

            return (a?.Real ?? 0) > (b?.Real ?? 0);
        }

        public static bool operator <(Complex a, Complex b)
        {
            if ((a?.Real ?? 0) == (b?.Real ?? 0))
                return (a?.Imag ?? 0) < (b?.Imag ?? 0);

            return (a?.Real ?? 0) < (b?.Real ?? 0);
        }

        /// ==
        public static bool operator ==(Complex a, Complex b)
        {
            if ((a?.Real ?? 0) == (b?.Real ?? 0))
                return (a?.Imag ?? 0) == (b?.Imag ?? 0);

            return false;
        }

        public static bool operator !=(Complex a, Complex b)
        {
            return !(a == b);
        }
    }
}
