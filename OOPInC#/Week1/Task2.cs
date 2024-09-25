using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInC_.Week1
{
    internal class Task2
    {
        public static void Main(string[] args)
        {
            Random random = new Random(2024);
            Console.WriteLine("Enter number of elements: ");
            int numEl = Convert.ToInt32(Console.ReadLine());

            int[] arrNum = new int[numEl];  
            for (int i = 0; i < numEl; i++) { arrNum[i] = random.Next(1000); }
            Console.WriteLine("Original order:");
            foreach (int el in arrNum) { Console.WriteLine(el); }

            arrNum = arrNum.Reverse().ToArray();
            Console.WriteLine("Reversed order:");
            foreach(int el in arrNum) { Console.WriteLine(el); }

        }
    }
}
