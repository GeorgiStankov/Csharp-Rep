﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num100to200
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            if (num < 100)
            {
                Console.WriteLine("Less than 100");
            }
            if (num >= 100 && num<=200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            if (num > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
