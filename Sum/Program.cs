using System;
using static System.Console;

Clear();

int number1 = new Random().Next(0,100);
int number2 = new Random().Next(0,100);

int result = number1+number2;

WriteLine(number1);
WriteLine(number2);
WriteLine(result);

//Division

WriteLine("Devision:");
int num3 = new Random().Next(0,100);
int num4 = new Random().Next(1,100);

int divResult = num3/num4;

WriteLine(num3);
WriteLine(num4);
WriteLine(divResult);
