﻿using System;

namespace SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 1;
            switch (myInt)
            {
                case 0:
                    Console.WriteLine("hallo, dit is case 0");
                    break;
                default:
                    Console.WriteLine("hallo, dit is de default case");
                    break;
            }
        }
    }
}
