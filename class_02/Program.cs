using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace class_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age;
            //Console.WriteLine("write your name here : ");
            //age = int.Parse(Console.ReadLine());
            //onsole.WriteLine(age);
            //prblem one
            //1.Write a C# Sharp program to print Hello and your name in a separate line
            //string name;
            //Console.Write("Write your name : ");
            //name = Console.ReadLine();
            //Console.WriteLine($"Hello: {name}");
            ////2.Write a C# Sharp program to print the sum of two number
            //int a, b, result=0;
            //Console.Write("enter your first number : ");
            //a=int.Parse ( Console.ReadLine());
            //Console.Write("enter your secend number : ");
            //b=int.Parse ( Console.ReadLine());
            //result = a + b;
            //Console.Write($"your result : {result}");

            //3.Write a C# Sharp program to print the result of dividing two numbers.
            //int a, b, result = 0;
            //Console.Write ("enter the first number : ");
            //a=int.Parse(Console.ReadLine());
            //Console.Write ("enter the secend number : ");
            //b = int.Parse(Console.ReadLine()) ;
            //result = a / b;
            //Console.WriteLine("your result : {0}", result);


            //4. Write a C# Sharp program to print the results of the specified operations.
            //Test data:

            // -1 + 4 * 6
            //Console.Write(-1 + 4 * 6);
            // (35 + 5) % 7
            //Console.Write((35 + 5) % 7);
            //14 + -4 * 6 / 11
            //Console.Write(14 + -4 * 6 / 11);
            //2 + 15 / 6 * 1 - 7 % 2
            //Console.Write(2 + 15 / 6 * 1 - 7 % 3);
            //Expected Output:
            //23
            //5
            //12
            //3

            //5.Write a C# Sharp program to swap two numbers.
            //Test Data:
            //Input the First Number : 5
            //Input the Second Number : 6
            //Expected Output:
            //After Swapping :
            //First Number : 6
            //Second Number : 5

            //int a, b,c;
            //Console.Write("enter the first number : ");
            //a= int.Parse(Console.ReadLine());
            //Console.Write("enter the secend number : ");
            //b=int.Parse(Console.ReadLine());
            //c = a;
            //a = b; b=c;
            //Console.Write("First Number : "+a +"\nSecond Number : "+b);

            //6.Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
            //Test Data:
            //Input the first number to multiply: 2
            //Input the second number to multiply: 3
            //Input the third number to multiply: 6
            //Expected Output:
            //2 x 3 x 6 = 36

            //int a, b, c, result=0;
            //Console.Write("input the first number to multipy : ");
            //a=int.Parse(Console.ReadLine());
            //Console.Write("input the second number to multipy : ");
            //b =int.Parse(Console.ReadLine());
            //Console.Write("input the third number to multipy : ");
            //c =int.Parse(Console.ReadLine());

            //result = a * b * c;
            //Console.Write("your result : {0}" , result);

            //7.Write a C# Sharp program to print on screen the output of adding, subtracting,
            //multiplying and dividing two numbers entered by the user.
            //Test Data:
            //Input the first number: 25
            //Input the second number: 4
            //Expected Output:
            //25 + 4 = 29
            //25 - 4 = 21
            //25 x 4 = 100
            //25 / 4 = 6
            //25 mod 4 = 1

            //int a, b;
            //Console.Write("input the first number: ");
            //a=int.Parse(Console.ReadLine());
            //Console.Write("input the second number: ");
            //b=int.Parse(Console.ReadLine());

            //Console.WriteLine($"{a} + {b} = {a + b}");
            //Console.WriteLine($"{a} - {b} = {a - b}");
            //Console.WriteLine($"{a} * {b} = {a * b}");
            //Console.WriteLine($"{a} / {b} = {a / b}");
            //Console.WriteLine($"{a} % {b} = {a % b}");

            //8.Write a C# Sharp program that prints the multiplication table of a number 
            //as input.
            //Test Data:
            //Enter the number: 5
            //Expected Output:
            //5 * 0 = 0
            //5 * 1 = 5
            //5 * 2 = 10
            //5 * 3 = 15....5 * 10 = 50

            //int a;
            //Console.Write("Enter the number : ");
            //a=int.Parse(Console.ReadLine());
            //for (int i = 0; i <= 10; i++) {
            //    Console.WriteLine("{0} * {1} = {2}", a,i,a*i);
            //}

            //9.Write a C# Sharp program that takes four numbers as input to calculate and print the average.
            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the third number: 20
            //Enter the four number: 30

            //Expected Output:
            //The average of 10 , 15 , 20 , 30 is: 18

            //int a,b,c,d;
            //Console.Write("Enter the First number: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //b = int.Parse(Console.ReadLine());
            //Console.Write("Enter the third number: ");
            //c = int.Parse(Console.ReadLine());
            //Console.Write("Enter the Foure number: ");
            //d = int.Parse(Console.ReadLine());

            //Console.Write($"The average of {a} , {b} , {c} , {d} is: {(a+b+c+d)/4}");

            //10.Write a C# Sharp program that takes three numbers (x,y,z) as input 
            // and outputs (x+y).z and x.y + y.z.
            //Test Data:
            //Enter first number - 5
            //Enter second number - 6
            //Enter third number - 7

            //Expected Output:
            //Result of specified numbers 5, 6 and 7, (x + y).z is 77 and x.y + y.z is 72

            //int x,y,z = 0;
            //Console.Write("Enter first number - ");
            //x=int.Parse(Console.ReadLine());
            //Console.Write("Enter second number - ");
            //y = int.Parse(Console.ReadLine());
            //Console.Write("Enter third number - ");
            //z = int.Parse(Console.ReadLine());
            //Console.Write($"Result of specified numbers {x}, {y} and {z},(x + Y)*z is {(x + y) * z} and x*y + y*z is {x * y + y * z}");

            //11.Write a C# Sharp program that takes an age (for example 20) as input and prints something
            //like "You look older than 20".
            //Test Data:
            //Enter your age - 25
            //Expected Output:
            //You look older than 25
            //int age;
            //Console.Write("Enter your age - ");
            //age = int.Parse(Console.ReadLine());
            //if (age > 20)
            //{
            //    Console.WriteLine("You look older than {0}", age);
            //}


            //12.Write a C# program that takes a number as input and
            //displays it four times in a row (separated by blank spaces),
            //and then four times in the next row, with no separation.
            //You should do it twice: Use the console. Write and use {0}.
            //Test Data:
            //Enter a digit: 25
            //Expected Output:
            //25 25 25 25
            //25252525
            //25 25 25 25
            //25252525

            //int a;
            //Console.Write("Enter adigit: ");
            //a=int.Parse(Console.ReadLine());

            //for (int i = 0; i < 4; i++) {
            //    for (int j = 0; j < 4; j++) {
            //        if (i % 2 == 0)
            //        {
            //            Console.Write("{0} ", a);
            //        }
            //        else {
            //            Console.Write("{0}", a);
            //        }

            //    }
            //    Console.WriteLine();
            //}


            //13.Write a C# program that takes a number as input and displays
            //a rectangle of 3 columns wide and 5 rows tall using that digit.
            //Test Data:
            //Enter a number: 5
            //Expected Output:
            //555
            //5 5
            //5 5
            //5 5
            //555

            //int a;
            //Console.Write("enter a number : ");
            //a= int.Parse(Console.ReadLine());
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 3; j++) {
            //        if (i == 0 || i == 4)
            //        {
            //            Console.Write(a);
            //        }
            //        else {
            //            Console.Write("{0} ",a);
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //14.Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
            //Test Data:
            //Enter the amount of celsius: 30
            //Expected Output:
            //Kelvin = 303
            //Fahrenheit = 86

            //int a;
            //Console.Write("Enter the amount of celsius : ");
            //a=int.Parse(Console.ReadLine());
            //Console.WriteLine(a + 273);
            //Console.WriteLine((a * 1.8) + 32);

            //15.Write a C# program that removes a specified character from
            //a non-empty string using the index of a character.
            //Test Data:
            //w3resource
            //Sample Output:
            //wresource
            //w3resourc
            //3resource

            //string a;
            //Console.Write("Enter the name : ");
            //a= Console.ReadLine();

            //Console.WriteLine(a.Remove(1, 1));
            //Console.WriteLine(a.Remove(9, 1));
            //Console.WriteLine(a.Remove(0, 1));

            //            16.Write a C# program to create a new string from a given
            //            string where the first and last characters change their positions.
            //Test Data:
            //w3resource
            //Python
            //x
            //Sample Output:
            //e3resourcw
            //nythoP
            //x

            //string a;
            //Console.Write("enter the string : ");
            //a= Console.ReadLine();
            //Console.WriteLine(a[a.Length - 1] + a.Substring(1, a.Length - 2) + a[0]);


            //            17.Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.
            //Sample Output:
            //Input a string : The quick brown fox jumps over the lazy dog.
            //TThe quick brown fox jumps over the lazy dog.T

            //string a;
            //Console.Write("enter the string : ");
            //a= Console.ReadLine();
            //Console.WriteLine(a[0] + a + a[0]);

            //            18.Write a C# program to check a pair of integers and
            //            return true if one is negative and one is positive.
            //Sample Output:
            //Input first integer:
            //            -5
            //Input second integer:
            //            25
            //Check if one is negative and one is positive:
            //True

            //int a,b;
            //Console.Write("enter the first number : ");
            //a=int.Parse(Console.ReadLine());
            //Console.Write("enter the second number : ");
            //b = int.Parse(Console.ReadLine());
            //if ((a > 0 && b < 0) || (a<0 && b>0)) {
            //    Console.WriteLine("Check if one is negative and one is positive");
            //}

            //17 agin 

            //int num1, num2;
            //Console.Write("enter the first number : ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.Write("enter the second number : ");
            //num2 = int.Parse(Console.ReadLine());
            //Console.Write(ngPt(num1, num2));

            //19.Write a C# program to compute the sum of two given integers.
            //If two values are the same, return the triple of their sum.
            int a, b;
            Console.Write("enter the first number : ");
            a=int.Parse(Console.ReadLine());
            Console.Write("enter the second number : ");
            b=int.Parse(Console.ReadLine());
            Console.Write(reTr(a,b));

















            Console.Read();


        }
        //static bool ngPt(int x, int y) {
        //    return ((x > 0 && y < 0) || (x < 0 && y > 0));
        //}
        static int reTr(int x, int y) {
            int result;
            if (x != y)
            {
                result= x + y;
            }
            else {
                result = (x + y) * 3;
            }
            return result;
        }

    }
}
