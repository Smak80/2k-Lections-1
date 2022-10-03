using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace L2k_2022_09_12
{
    public class Complex
    {
        protected static int count = 0;
        protected int index;
        protected static double EPSILON = 1e-25;
        public static int Count
        {
            get => count;
        }

        protected double im;

        public double Re { get; set; }

        public double Im
        {
            get => im;
            set => im = value;
        }

        public double? this[char part]
        {
            get
            {
                if (part == 'r' || part == 'R') return Re;
                if (part == 'i' || part == 'I') return Im;
                return null;
            }
            set
            {
                if (value != null)
                {
                    if (part == 'r' || part == 'R') Re = (double)value;
                    if (part == 'i' || part == 'I') Im = (double)value;
                }
            }
        }

        public double roIm => im;

        public double Abs => Math.Sqrt(Re * Re + Im * Im);

        public Complex()
        {
            count++;
            index = count;
        }

        public Complex(double re, double im)
        {
            Re = re;
            this.im = im;
            count++;
            index = count;
        }

        public Complex(Complex other)
        {
            Re = other.Re;
            im = other.im;
            count++;
            index = count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(index);
            sb.Append("):");
            if (Math.Abs(Re) > 10 * Double.Epsilon ||
                Math.Abs(Im) < 10 * Double.Epsilon)
                sb.Append(Re);
            if (Math.Abs(Im) > 10 * Double.Epsilon)
            {
                sb.Append(Im > 0 ? " + " : " - ");
                if (Math.Abs(Math.Abs(Im) - 1) > 10 * Double.Epsilon) 
                    sb.Append(Math.Abs(Im));
                sb.Append("i");
            }
            return sb.ToString();
        }

        public Complex Plus(Complex other) =>
            new (Re + other.Re, Im + other.Im);

        public static Complex operator+(Complex z1, Complex z2) =>
            new (z1.Re + z2.Re, z1.Im + z2.Im);

        public static Complex operator -(Complex z1, Complex z2) =>
            new(z1.Re - z2.Re, z1.Im - z2.Im);

        public static Complex operator -(Complex z1) =>
            new(z1.Re, -z1.Im);

        public static bool operator ==(Complex it, Complex other)
        {
            return Math.Abs(it.Re - other.Re) < EPSILON && 
                   Math.Abs(it.Im - other.Im) < EPSILON;
        }

        public static bool operator !=(Complex it, Complex other) => !(it == other);

        public override bool Equals(object? obj)
        {
            /*if (obj == null) return false;
            if (obj.GetType() != typeof(Complex)) return false;
            Complex x = (Complex)obj;*/
            if (obj is Complex x)
                return Math.Abs(Re - x.Re) < EPSILON && Math.Abs(Im - x.Im) < EPSILON;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Re, Im);
        }
    }
}
