using System;
using static System.Console;

Clear();

WriteLine("Please type your name");

string name = ReadLine();

if (name.ToLower () == "iryna")
{
WriteLine("Hey, Iryna! Glad to see you!");
}
else
{
    Write("Hello, ");
    WriteLine (name);
    }
