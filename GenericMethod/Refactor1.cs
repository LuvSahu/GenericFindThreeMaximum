using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Refactor1
    {
        public void ToMax<T>(T Num1, T Num2, T Num3)
        {
            T[] find = new T[] { Num1, Num2, Num3 };
            Array.Sort(find);
            Console.WriteLine($"Max value is: {find[2]}");
        }

    }
}

