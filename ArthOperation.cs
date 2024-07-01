using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArraysOperations
{
    public class ArthOperation
    {
        //--------------below is sum by function
        //public void Sum()
        //{
        //    Console.WriteLine("Enter the first number: ");
        //    var a = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter the first number: ");
        //    var b = int.Parse(Console.ReadLine());

        //    var Sum = a + b;
        //    Console.WriteLine("Sum : {0}", Sum);
        //}



        //----------------function for sum of digits in each other
        //public void sumDigits()
        //{
        //    int n, sum = 0, m;
        //    Console.WriteLine("Enter a number: ");
        //    n = int.Parse(Console.ReadLine());
        //    while (n > 0)
        //    {
        //        m = n % 10;  
        //        sum = sum + m;
        //        n = n / 10;  
        //    }
        //    Console.WriteLine("Sum of the digits is: " + sum);

        //}



        //-----------------------------Add py to a string
        //public void AddPy()
        //{
        //    string name;
        //    string py;
        //    Console.WriteLine("Enter string :");
        //    name = Console.ReadLine();

        //    if (name.StartsWith("py"))
        //    {
        //        Console.WriteLine("string already start with py: " + name);
        //    }
        //    else
        //    {
        //        Console.WriteLine("string already start with py: " + "py" + name);
        //    }
        //}




        //-------------------for remove character at specific index
        //public void test()
        //{

        //    Console.WriteLine("Enter string :");
        //    var str = Console.ReadLine();
        //    Console.WriteLine("Enter index :");
        //    var character1 = int.Parse(Console.ReadLine());
        //    if (character1 < 0 || character1 >= str.Length)
        //    {
        //        Console.WriteLine("invalid index :");

        //    }
        //    var resultString = str.Remove(character1, 1);
        //    Console.WriteLine(resultString);

        //}



        //------------Table of any number giving by user
        //public void TableOf()
        //{
        //    Console.WriteLine("Enter number for Create table");
        //    var num1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter number upto");
        //    var num2 = int.Parse(Console.ReadLine());
        //    for(int i = 1; i <=num2; i++)
        //    {
        //        var result = num1 * i;
        //        Console.WriteLine($"{num1} X {i}=" + result);
        //    }
        //}


        //-------------------Exchange first and last character in each other
        //public void ExchangeCharacter()
        //{
        //    Console.WriteLine("Enter your String");
        //    var NewString = Console.ReadLine();
        //    if(NewString != null)
        //    {
        //        var result = NewString.Substring(1, NewString.Length - 2);
        //        var str1 = NewString.Substring(0,1);
        //        var str2 = NewString.Substring(NewString.Length - 1);

        //        Console.WriteLine(str2+ result+ str1);
        //    }
        //}


        //-------------------Adding first character and add to front and back to string
        //public void AddCharacterFront()
        //{
        //    Console.WriteLine("Enter your String");
        //    var NewString = Console.ReadLine();
        //    if (NewString != null)
        //    {    
        //        var str1 = NewString.Substring(0, 1);
        //        Console.WriteLine(str1+ NewString+ str1);
        //    }
        //}

    }

}
