using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionOverloading
{

    class User
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public static User operator +(User user1,User user2)
        {
            User resultUser = new User();
            resultUser.Name = user1.Name + "," + user2.Name;
            resultUser.Money = user1.Money + user2.Money;
            return resultUser;
        }
    }

    //取整，之前要实现的一个功能，现在用重载操作符来完成了
    class add
    {
        public float value;
        public add(float value)
        {
            this.value = value;
        }
        public static add operator +(add num1,add num2)
        {
            add result = new add(0f);
            result.value = num1.value + num2.value;
            if ((int)result.value != result.value)
                result.value = (int)result.value + 1;
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Name = "A";
            user1.Money = 5;

            User user2 = new User();
            user2.Name = "B";
            user2.Money = 7;

            User sumUser = user1 + user2;

            Console.WriteLine("name:{0}", sumUser.Name);
            Console.WriteLine("money:{0}", sumUser.Money);

            add num1 = new add(3.2f);
            add num2 = new add(2.02f);
            add resultNum = num1 + num2;

            Console.WriteLine("{0}", resultNum.value);

            Console.Read();
        }
    }
}
