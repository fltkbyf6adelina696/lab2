using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
class Program
{
static void Main(string[] args)
{
Console.Write(" a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(" b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write(" c = ");
int c = Convert.ToInt32(Console.ReadLine());
if (a == 0)
{
Console.WriteLine("", b,c );
if (b == 0)
{
Console.WriteLine(" Нет корней");
}
else
{
double x = 0;
x = -c / b;
Console.WriteLine(" x = {0}", x);
}
}
else
{
double d;
d = b * b - 4 * a * c;

if (d < 0)
{
Console.WriteLine(" Нет корней");

}
if (d == 0)
{
double x1 = b / (2 * a);
Console.WriteLine(" x = {0}", x1);

}
if (d > 0)
{
double x1 = (-b + Math.Sqrt(Convert.ToDouble(d))) / (2 * a);
double x2 = (-b - Math.Sqrt(Convert.ToDouble(d))) / (2 * a);
Console.WriteLine(" x1 = {1}, x2 = {2}", d, x1, x2);
}
}
}
}
}