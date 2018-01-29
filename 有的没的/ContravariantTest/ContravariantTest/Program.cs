using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContravariantTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog aDog = new Dog();
            Animal aAnimal = aDog;

            List<Dog> lstDogs = new List<Dog>();
            List<Animal> lstAnimal = lstDogs.Select(d => (Animal)d).ToList();

            IEnumerable<Dog> someDogs = new List<Dog>();
            IEnumerable<Animal> someAnimals = someDogs;

            Action<Animal> actionAnimal = new Action<Animal>(a => { /*动物叫*/});
            Action<Dog> actionDog = actionAnimal;
            actionDog(aDog);
        }
    }

    public abstract class Animal
    {

    }
    /// <summary>
    /// Dog继承于Animal类
    /// Dog变成Animal就是和谐的变化（协变)
    /// 如果Animal变成Dog就是不正常的变化（逆变）
    /// </summary>
    public class Dog : Animal
    {

    }

}
