﻿using System;

namespace _01.Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string result = spy.StealFieldInfo(typeof(Hacker).FullName, "username", "password");
            Console.WriteLine(result);
        }
    }
}
