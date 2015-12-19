﻿using System;
using AdventOfCode.Days;

namespace AdventOfCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // http://adventofcode.com/
            IRunner codeDay;
            // codeDay = new DayOne();
            // codeDay = new DayTwo();
            // codeDay = new DayThree();
            // codeDay = new DayFour();
            // codeDay = new DayFive();
            // codeDay = new DaySix();
            codeDay = new DaySeven();

            codeDay.Run();
            Console.ReadLine();
        }
    }
}