﻿using System.Collections;
using System;
class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");
        stack.Push("Fourth");
        while (stack.Count > 0)
        {
            object obj = stack.Pop();
            Console.WriteLine("'From Stack: {0}", obj);
        }

    }
}
