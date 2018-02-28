using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOverloading
{
    public struct Complex
    {
        public int real;
        public int imaginary;
        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static Complex operator +(Complex complex1,Complex complex2)
        {
            Complex result = new Complex();
            result.real = complex1.real + complex2.real;
            result.imaginary = complex1.imaginary + complex2.imaginary;
            return result;
        }
        public override string ToString()
        {
            return string.Format("{0}+{1}i", real, imaginary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex number1 = new Complex(1, 2);
            Complex number2 = new Complex(3, 4);
            Complex sum = number1 + number2;

            Console.WriteLine("{0}", number1);
            Console.WriteLine("{0}", number2);
            Console.WriteLine("{0}", sum);

            Console.Read();
        }
    }
}
