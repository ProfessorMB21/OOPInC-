using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInC_.Week1
{
    internal class Task1
    {
        public static void Main(string[] args)
        {

            Color color;

            foreach (var col in Enum.GetValues(typeof(Color)))
            {
                switch (col) 
                {
                    case Color.RED: { color = Color.RED; Console.WriteLine("RED"); break; }
                    case Color.BLUE: { color = Color.BLUE; Console.WriteLine("BLUE"); break; }
                    case Color.GREEN: { color = Color.GREEN; Console.WriteLine("GREEN"); break; }
                }
            }

        }
    }

    enum Color
    {
        RED, GREEN, BLUE
    }

}
