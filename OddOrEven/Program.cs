
using System.ComponentModel.Design;

Console.WriteLine("Enter a number:");

int userNum = Convert.ToInt32(Console.ReadLine());

int result = userNum % 2;

if (result != 0) 
{
    Console.WriteLine("Number is odd");
}
else
{
    Console.WriteLine("Number is even");
}
