using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStringMethod
{
    public delegate String myMehodDelegate(int myInt);
    public class mySampleClass
    {
        public String myStringMethod(int myInt)
        {
            if (myInt > 0)
                return "positive";
            if (myInt < 0)
                return "negative";
            else
                return "zero";
        }
        public static String mySignMethod(int myInt)
        {
            if (myInt > 0)
                return "+";
            if (myInt < 0)
                return "-";
            else
                return "";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            mySampleClass mySC = new mySampleClass();
            myMehodDelegate myD1 = new myMehodDelegate(mySC.myStringMethod);
            myMehodDelegate myD2 = new myMehodDelegate(mySampleClass.mySignMethod);

            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", 5, myD1(5), myD2(5));
            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", -3, myD1(-3), myD2(-3));
            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", 0, myD1(0), myD2(0));
            Console.Read();
        }
    }

    

}

