﻿using System.Runtime.CompilerServices;

namespace MembersandFinalizers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Members member1 = new Members();
            member1.Introducing(true);
            Console.ReadKey();
        }

    }
}