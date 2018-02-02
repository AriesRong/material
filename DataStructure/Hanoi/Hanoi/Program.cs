using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Hanoi(n, "TowerA", "TowerB", "TowerC");
            Console.ReadLine();
        }
        private static void Hanoi(int n, string origin, string temp, string destination)
        {
            if (n == 1)
                move(n, origin, destination);
            else
            {
                Hanoi(n - 1, origin, destination, temp);//(A,C,B)
                move(n, origin, destination);
                Hanoi(n - 1, temp, origin, destination);
            }
        }

        private static void move(int n, string origin, string destination)
        {
            Console.WriteLine("Move the palte" + n.ToString() + " form " + origin + " to " + destination);
        }
    }
}
