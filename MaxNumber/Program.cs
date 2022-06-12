using System;
using static System.Console;

Clear();
int a = new Random().Next(0,10);
int b = 6;
int c = 1;
int d = 7;
int e = 9;

int maxNum = a;

if (a>maxNum) {maxNum = a;}
if (b>maxNum) {maxNum = b;}
if (c>maxNum) {maxNum = c;}
if (d>maxNum) {maxNum = d;}
if (e>maxNum) {maxNum = e;}

WriteLine(a);
Write("Max number is ");
WriteLine (maxNum);