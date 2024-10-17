using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Challenges
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my coding challenge program, there will be a variety of different functions you will have to choose from. Please pick one.");

            Console.WriteLine("today we are going to use the number adder called SUM. Please input two numbes for us to add. \n");

        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);

        Console.WriteLine("Awesome! please input a second number");


        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);
        Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to:" + Sum(number1int, number2int));
        Sum(number1int, number2int);
        Console.WriteLine("lets try converting minutes to seconds./ give me an number to conver from minutes to seconds");

        var number3 = Console.ReadLine();
        int number3int = int.Parse(number3);
        Console.WriteLine(number3 + " Minutes converted to seconds is: " + Converet(number3int) + " seconds ");

        Console.WriteLine("Now try adding on  e to any number.\n give me a number to add one to.");

        var number4 = Console.ReadLine();
        int number4int = int.Parse(number4);

        Console.WriteLine(number4 + " the sum of your number plus one is equal to : " + PlusOne(number4int) + " ");

        Console.WriteLine("Now lets convert voltage and current into power. please input one voltage and one current for us to convert to power.\n");

        var number5 = Console.ReadLine();
        int number5int = int.Parse(number5);

        Console.WriteLine(" great please input a current");
        var number6 = Console.ReadLine();
        int number6int = int.Parse(number6);

        Console.WriteLine(" the total power of your voltage and your current is equal to power. " + Circuit(number5int, number6int));
        Circuit(number5int, number6int);

        Console.WriteLine(" now lets convert your age in years into days.\n please give me your age in years");
        var number7 = Console.ReadLine();
        int number7int = int.Parse(number7);

        Console.WriteLine(number7 + " your age in days is " + CalcAge(number7int) + " days");


        Console.WriteLine(" Lets find the area of a triangle \n. please give me the base of the triangle.");
        var number8 = Console.ReadLine();
        int number8int = int.Parse(number8);

        Console.WriteLine(" Amazing! Please give me the height of the triangle");
        var number9 = Console.ReadLine();
        int number9int = int.Parse(number9);

        Console.WriteLine(" The area of your triangle is: " + triArea(number8int, number9int));


        Console.WriteLine(" Lets find out if a number is less than or equal to zero. \n. Please give me a number to find if its less than or equal to zero");
        var number10 = Console.ReadLine();
        int number10int = int.Parse(number10);
        Console.WriteLine(LessThanOrEqualtoZero(number10int)); 
     
        Console.WriteLine( " ")
    }

    
    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }
  
    public static int Converet(int number)
    {
        return number * 60;
    }

   public static int PlusOne(int number)
    {
        return number + 1;
    }
    
    public static int Circuit(int number5, int number6)
    {
        return number5 * number6;

    }

    public static int CalcAge(int number)
    {
        return number * 365;
    }

    
    public static float triArea(float number8, float number9)
    {
        return (number8 * number9) /2;
    }

    public static bool LessThanOrEqualtoZero(int number)
    {

        return number <= 0;
    }
}




