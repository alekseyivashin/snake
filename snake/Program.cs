﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.x = 5;
            p.y = 6;
            p.sym = '^';
            p.Draw();
            
            Console.ReadLine();
        }
    }
}
