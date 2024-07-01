using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArraysOperations.ArrayOperation
{
    public class AdvancedArrayOperation
    {
        //public void CheckMultipleThree()
        //{
        //    Console.WriteLine("Enter Array of numbers to check multiples of three and five");
        //    string Arr = Console.ReadLine();
        //    string[] NewArray = Arr.Split(',');
        // 
        //    for (int i = 0; i < NewArray.Length; i++)
        //    {
        //        int number = int.Parse(NewArray[i]);
        //        if (number % 3 == 0 && number % 5 == 0)
        //        {
        //            Console.WriteLine($" {number} is FizzBuzz");
        //        }
        //        else if (number % 3 == 0)
        //        {
        //            Console.WriteLine($" {number} is Fizz");
        //        }
        //        else if (number % 5 == 0)
        //        {
        //            Console.WriteLine($" {number} is Buzz");
        //        }else
        //        {
        //            Console.WriteLine("number not valid");
        //        }
        //    }
        //}


        //when use keyword retur then calling method slicly changed in program.cs
        //public  int Sum()
        //{

        //    int n1 = int.Parse(Console.ReadLine());
        //    int n2 = int.Parse(Console.ReadLine());
        //    int result = n1+n2;
        //    return result;
        //}


        //public int SumArray()
        //{
        //    int[] numbersArray = [1, 13, 22, 123, 49];
        //    int numbers = 0;
        //    int result = 0;
        //    for (int i = 0; i < numbersArray.Length; i++) 
        //    {

        //        //numbers = numbersArray[i];
        //        numbers = numbers + numbersArray[i];

        //    }
        //    return numbers;
        //}


        //Sum of multiples of three and five
        //public int SumUnderThousand()
        //{
        //    Console.WriteLine("Enter Array");
        //    string FirstArray = Console.ReadLine();
        //    string[] FinalArr = FirstArray.Split(',');
        //    int result = 0;
        //    for (int i = 0; i < FinalArr.Length; i++)
        //    {
        //        if (int.Parse(FinalArr[i]) % 3 == 0 && int.Parse(FinalArr[i]) % 5 == 0)
        //        {
        //            result = result + int.Parse(FinalArr[i]);
        //        }
        //    }
        //    return result;
        //}


        //Check whether given number is positive or negitive
        //public void PositveOrNegitive()
        //{
        //    Console.WriteLine("Enter Array");
        //    string number1 = Console.ReadLine();
        //    string[] FinalNumber = number1.Split(',');
        //    for(int i=0; i<FinalNumber.Length; i++)
        //    {
        //        if (int.Parse(FinalNumber[i]) > 0)
        //        {
        //            Console.WriteLine($" {FinalNumber[i]} is positive ");
        //        }else
        //            if(int.Parse(FinalNumber[i]) < 0)
        //        {
        //            Console.WriteLine($" {FinalNumber[i]} is negitive ");
        //        }
        //    }
        //}


        //Ticket Price based on Age
        //public void TicketPriceOnAge()
        //{
        //    Console.WriteLine("Enter Your Age");
        //    int age = int.Parse(Console.ReadLine());
        //    if(age < 12)
        //    {
        //        Console.WriteLine($"with age of {age} pay ticket price = 5 ");
        //    }else
        //    if (age > 12 && age < 18)
        //    {
        //        Console.WriteLine($"with age of {age} pay ticket price = 10 ");
        //    }
        //    else
        //    if (age > 18 && age < 60)
        //    {
        //        Console.WriteLine($"with age of {age} pay ticket price = 20 ");
        //    }
        //    else
        //    if (age > 60)
        //    {
        //        Console.WriteLine($"with age of {age} you are free of cost ");
        //    }

        //}



        //Sum of two array
        //public int SumOfTwoArray()
        //{
        //    int result1 = 0;
        //    int result2 = 0;
        //    int result;
        //    Console.WriteLine("Enter First Array");
        //    string Array1 = Console.ReadLine();
        //    string[] SplitArray = Array1.Split(',');

        //    Console.WriteLine("Enter Second Array");
        //    string Array2 = Console.ReadLine();
        //    string[] SplitArray2 = Array2.Split(',');
        //    for(int i = 0; i< SplitArray.Length; i++)
        //    {
        //        result1 = result1 + int.Parse(SplitArray[i]);
        //    }

        //    for(int i = 0; i < SplitArray2.Length; i++)
        //    {
        //        result2 = result2 + int.Parse(SplitArray2[i]);
        //    }
        //    result = result1 + result2;
        //    return result;
        //}


        //public void DiscountOnPrice()
        //{
        //    float discount = 0;
        //    Console.WriteLine("Enter Price");
        //    float price = float.Parse(Console.ReadLine());
        //    if (price >= 100)
        //    {
        //        discount = 20f / 100 * 100;
        //        Console.WriteLine($"Your discount on {price} rupees is: {discount}");
        //    }
        //    else if (price >= 50 && price < 100)
        //    {
        //        discount = 10f / 100 * 100;
        //        Console.WriteLine($"Your discount on {price} rupees is: {discount}");
        //    }

        //}



        //public void FictorialOf()
        //{
        //    Console.WriteLine("Enter Price");
        //    float price = float.Parse(Console.ReadLine());
        //    double factorial = 1.0;
        //    for (int i = 1; i <= price; ++i)
        //    {
        //        factorial *= i;
        //        //the above factorial *= i mean factorial = factorial * 1

        //    }
        //    Console.WriteLine($"the factorail of {price} is: " + factorial);
        //}


        //public void DoubleTheArray()
        //{
        //    Console.WriteLine("Enter Your Array");
        //    string Arr = Console.ReadLine();
        //    string[] resultArray = Arr.Split(',');
        //    int[] squaredArray = new int[resultArray.Length];
        //    for (int i = 0; i < resultArray.Length; i++)
        //    {
        //        int num = int.Parse(resultArray[i]);
        //        squaredArray[i] = num * num;
        //    }
        //    Console.WriteLine($"[" + string.Join(", ", squaredArray) + "]");
        //}


        //public void NumbersToString()
        //{
        //    Console.WriteLine("Enter Your Array");
        //    string Arr = Console.ReadLine();
        //    string[] items = Arr.Split(',');
        //    Console.Write($"[\"{string.Join("", items)}\"]");
        //}


        //public void CapitalizeItems()
        //{
        //    Console.WriteLine("Enter your Array in small letters");
        //    string ItemeArr = Console.ReadLine();
        //    string resultArr = ItemeArr.ToUpper();
        //    Console.WriteLine(resultArr);
        //}


        //public void SqureElement()
        //{
        //    Console.WriteLine("Enrer your digits array");
        //    string numberArr = Console.ReadLine();
        //    string[] newArr = numberArr.Split(',');
        //    int[] result = new int[newArr.Length];
        //    for(int i = 0; i < newArr.Length; i++) 
        //    {
        //        int items = int.Parse(newArr[i]);
        //        result[i] = items * items;            
        //    }
        //    Console.Write($"[" + string.Join(",", result) + "]");
        //}


        //public void ArmstrongNumbers()
        //{
        //    Console.WriteLine("Enter your Array");
        //    string armstrong = Console.ReadLine();
        //    string[] NewArmstrong = armstrong.Split(',');

        //    for (int i = 0; i < NewArmstrong.Length; i++)
        //    {
        //        string items = NewArmstrong[i];
        //        int num1 = int.Parse(items.Substring(0, 1));
        //        int num2 = int.Parse(items.Substring(1, 1));
        //        int num3 = int.Parse(items.Substring(2, 1));
        //        double item1 = Math.Pow(num1, 3);
        //        double item2 = Math.Pow(num2, 3);
        //        double item3 = Math.Pow(num3, 3);
        //        double FirstLast = item1 + item2 + item3;
        //        if (FirstLast.ToString() == items)
        //        {
        //            Console.WriteLine($"the number {items} is Armstrong");
        //        }
        //    }
        //}
    }
}







