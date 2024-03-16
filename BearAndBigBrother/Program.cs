using static System.Console;
using static System.Convert;
using static System.Math;

int a, b, counter = 0;


string str = ReadLine();
var arr = str.Split(" ");
a = ToInt32(arr[0]);
b = ToInt32(arr[1]);
while (a <= b)
{
    a *= 3;
    b *= 2;
    counter++;
}

WriteLine(counter);


