using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysOperations.ArrayOperation
{
    public class ArrayFunction
    {
        //public void DivisibleByThree()
        //{
        //    Console.WriteLine("Enter the number to check it divisible by 3 and 7");
        //    var num1 = int.Parse(Console.ReadLine());
        //    if(num1%3 == 0 && num1%7 == 0)
        //    {
        //        Console.WriteLine($" {num1} number is divisble by 3 and 7 ");
        //    }else
        //    {
        //        Console.WriteLine($" {num1} number is not divisible by 3 and 7");
        //    }
        //}


        //-------------------Adding last three character and add to front and back to string
        //public void AddLastCharacters()
        //{
        //    Console.WriteLine("Enter your String");
        //    var NewString = Console.ReadLine();
        //    if (NewString != null)
        //    {
        //        var str1 = NewString.Substring(NewString.Length-3);
        //        Console.WriteLine(str1 + NewString + str1);
        //    }
        //}


        //Find largest number in Array
        //public void LargestNumber()
        //{
        //    Console.WriteLine("Enter the numbers separated by commas:");
        //    string input = Console.ReadLine();
        //    string[] inputArray = input.Split(',');
        //    int largest = int.Parse(inputArray[0]);

        //    for (int i = 0; i < inputArray.Length; i++)
        //    {
        //        int number = int.Parse(inputArray[i]);
        //        if (number > largest)
        //        {
        //            largest = number;
        //        }
        //    }

        //    Console.WriteLine("The largest number is: " + largest);

        //}


        //Find Grade
        //public void CalculateGrade()
        //{
        //    Console.WriteLine("Enter your obtained marks");
        //    int marks = int.Parse(Console.ReadLine());
        //    if (marks > 100)
        //    {
        //        Console.WriteLine("Marks limit is 100 do not exceed to this");
        //    }
        //    else if (marks >= 89 || marks >= 100)
        //    {
        //        Console.WriteLine("You have get A+ Grade");
        //    }
        //    else { Console.WriteLine("you have not ger A+ Grade"); }

        //    if (marks >= 90)
        //    {
        //        Console.WriteLine("True");
        //    }
        //    else
        //    {
        //        Console.WriteLine(" ");
        //    }

        //}


        //Check sum is in the range
        //public void SumDigits()
        //{
        //    Console.WriteLine("Enter First Number");
        //    int num1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Second Number");
        //    int num2 = Convert.ToInt32(Console.ReadLine());
        //    int Sum = num1 + num2;
        //    if(Sum > 50 &&  Sum < 80)
        //    {
        //        Console.WriteLine($" Your given Numbers {num1} and {num2} is in the range of 50 and 80 :True");
        //    }
        //    else
        //    {
        //        Console.WriteLine("False");
        //    }

        //}


        //Reverse the Array
        //public void simpleTest() {
        // Object[] arr = [43, "what", 9, true, "cannot", false, "be", 3, true];
        //    Object[] reverse = new Object[arr.Length];
        //int j = arr.Length - 1;
        //    for (int i = 0; i< arr.Length; i++)
        //    {

        //         reverse[i] = arr[j];
        //        Console.WriteLine(reverse[i]);
        //        j--;
        //    }

        // }


        //Reverse the Array
        //public void simple()
        //    {
        //        int[] numbers = new int[] { 1, 2, 3, 4, 5 };
        //        int[] reverse = new int[numbers.Length];
        //        int j = numbers.Length - 1;
        //        for (int i = 0; i < numbers.Length; i++)
        //        {

        //            reverse[i] = numbers[j];
        //            Console.WriteLine(reverse[i]);
        //            j--;
        //        }
        //    }



        //Check Numbers Odd and Even
        //public void CheckOddEven()
        //{
        //    Console.WriteLine("Enter Array upto 15");
        //    string ArrFirst = Console.ReadLine();
        //    string[] NewArr = ArrFirst.Split(',');
        //    for (int i = 0; i < NewArr.Length; i++)
        //    {
        //        if (int.Parse(NewArr[i])%2  == 0)
        //        {
        //            Console.WriteLine($" {NewArr[i]} is Even");
        //        }else
        //        {
        //            Console.WriteLine($"{NewArr[i]} is Odd");
        //        }
        //    }
        //}
    }

}
