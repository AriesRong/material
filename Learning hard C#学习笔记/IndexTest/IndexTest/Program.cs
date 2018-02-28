using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            //索引器可以让我们像访问数组一样访问类中的数据
            person[0] = 1;
            person[1] = 2;
            person[2] = 2;
            person.Name = "test";

            Console.WriteLine(person[0]);
            Console.WriteLine(person[1]);
            Console.WriteLine(person[2]);
            Console.WriteLine(person.Name);
            Console.Read();
        }
    }
    class Person
    {
        private int[] intArray = new int[10];
        public string Name { get; set; }
        //索引器的定义
        public int this[int index]
        {
            get { return intArray[index] + 5; }
            set { intArray[index] = value; }
        }
    }
}
