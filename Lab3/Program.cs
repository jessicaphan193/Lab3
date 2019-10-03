using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            SportCar myCar = new SportCar();
            myCar.PetName = "my beatup Sienna";
            Console.WriteLine("My car: {0},\t{1}", myCar.getPetName(), myCar.PetName);
        }
    }
}
