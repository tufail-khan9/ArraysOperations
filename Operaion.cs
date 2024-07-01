using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysOperations
{
    public class Operaion
    {
        //public void MeanAndMedian()
        //{
        //    Console.WriteLine("Enter Array");
        //    string arr = Console.ReadLine();
        //    string[] newArr = arr.Split(',');
        //    int[] sorted = new int[newArr.Length];
        //    for (int i = 0; i < newArr.Length; i++)
        //    {
        //        sorted[i] = int.Parse(newArr[i]);
        //    }
        //    Array.Sort(sorted);
        //    float num = 0;
        //    for (int i = 0; i < sorted.Length; i++)
        //    {
        //        num = num + sorted[i];
        //    }
        //    float NumResult = num / sorted.Length;
        //    int size = sorted.Length;
        //    int mid = size / 2;
        //    double median = (size % 2 != 0) ? (double)sorted[mid] : ((double)sorted[mid] + (double)sorted[mid - 1]) / 2;

        //    Console.Write($" mean of given array is :[" + string.Join(", ", NumResult) + "]\n");
        //    Console.Write($" median of given array is :[" + string.Join(", ", median) + "]");
        //}


        //Get initials of strings mean extract the first character of each
        //string and combined them like tufail khan jaan 
        //now the output is tkj
        //public void GetInitials()
        //{
        //    Console.WriteLine("Enter your with single space without commas(,)");
        //    string Initials = Console.ReadLine();
        //    string[] InitialArray = Initials.Split(' ');
        //    string[] Items = new string[InitialArray.Length];

        //    for (int i = 0; i < InitialArray.Length; i++)
        //    {
        //        Items[i] = InitialArray[i].Substring(0, 1);

        //        //Items[i] = InitialArray[i].Substring(0, 1);
        //    }

        //    Console.Write($"[{string.Join("", Items)}]");
        //}



        //Differentiate between Oldest Age and Younget Age
        //public void DifferentiateAges()
        //{
        //    Console.WriteLine("Enter your Array with different Ages");
        //    string Ages = Console.ReadLine();
        //    string[] InitialAges = Ages.Split(',');
        //    int[] numbersArray = new int[InitialAges.Length];
        //    int largest = 0;
        //    int smallest = int.Parse(InitialAges[0]);
        //    int result = 0;
        //    for (int i = 0; i < InitialAges.Length; i++)
        //    {
        //        //largest = numbersArray[i];
        //        if (largest < int.Parse(InitialAges[i]))
        //        {
        //            largest = int.Parse(InitialAges[i]);
        //        }
        //    }
        //    for (int j = 0; j < InitialAges.Length; j++)
        //    {
        //        if (smallest > int.Parse(InitialAges[j]))
        //        {
        //            smallest = int.Parse(InitialAges[j]);
        //        }
        //        result = largest - smallest;
        //    }
        //    Console.WriteLine("the largest Age in Your family is:" + largest);
        //    Console.WriteLine("the smallest Age in Your family is: " + smallest);
        //    Console.WriteLine("the differentiat in Age is: " + result);

        //}



        //----Genrate new array form existing that numbers 5 or greater------

        //public void FiveOrGreater()
        //{
        //    Console.WriteLine("Enter your Array");
        //    string num = Console.ReadLine();
        //    string[] InitialNum = num.Split(',');
        //    int[] FinalaArr = new int[InitialNum.Length];

        //    for (int i = 0; i < InitialNum.Length; i++)
        //    {
        //        int number = int.Parse(InitialNum[i]);
        //        if (number >= 5)
        //        {
        //            FinalaArr[i] = number;
        //        }
        //    }

        //    // Filter out the zeros and create a new array for output
        //    int[] resultArr = FinalaArr.Where(x => x != 0).ToArray();

        //    Console.Write($"[{string.Join(", ", resultArr)}]");
        //}



        //----------------Only return Even number----------------

        //public void OnlyEvenNumbers()
        //{
        //    Console.WriteLine("Enter your Array");
        //    string num1 = Console.ReadLine();
        //    string[] NumArr = num1.Split(',');
        //    int[] FinalaArr = new int[NumArr.Length];

        //    for (int i = 0; i < NumArr.Length; i++)
        //    {
        //        int number = int.Parse(NumArr[i]);
        //        if (number % 2 == 0)
        //        {
        //            FinalaArr[i] = number;
        //        }
        //    }
        //    int[] resultArr = FinalaArr.Where(x => x != 0).ToArray();
        //    Console.Write($"[{string.Join(", ", FinalaArr)}]");
        //}


        //----return an array that Less than or equal to Five character-----
        //public void FiveOrLessThan()
        //{
        //    Console.WriteLine("Enter your Array");
        //    string items = Console.ReadLine();
        //    string[] NumItems = items.Split(',');
        //    string[] ItemsArr = new string [NumItems.Length];
        //    for(int i = 0; i < NumItems.Length; i++)
        //    {
        //        string name = NumItems[i];
        //        if(name.Count() <= 5) 
        //        {
        //            ItemsArr[i] = name;
        //        }
        //    }
        //    string[] resultArr = ItemsArr.Where(x => x != null).ToArray();
        //    Console.Write($"[{string.Join(", ", resultArr)}]");
        //}


        //Show color
        //public void ShowColor()
        //{
        //Console.WriteLine("\nPlease enter desired background color for this screen: ");
        //var screen = Console.ReadLine();
        //Console.WriteLine("\nPlease enter desired text color for this screen: ");
        //var text = Console.ReadLine();
        //// Attempt to parse the colors that the user entered into their respective enum values.
        //// The new values of background and foreground will be set to the user input
        //if (Enum.TryParse(screen, out ConsoleColor background))
        //{
        //    Console.BackgroundColor = background;
        //}
        //if (Enum.TryParse(text, out ConsoleColor foreground))
        //{
        //    Console.ForegroundColor = foreground;
        //}

        //Console.BackgroundColor = ConsoleColor.Blue;
        //Console.Clear();
        //Console.ForegroundColor = ConsoleColor.White;
        //}


        //For Check specific string name in array
        //public void CheckString()
        //{
        //    string[] Courses = { "javaScript", "CSS", "HTML", "react js", "data structures", "algorithms" };
        //    string[] Courses2 = { "rameen", "rashid", "ali", "alina", "aliya", "mahnoor", "mehwish", "sana", "tahira", "taimoor" };
        //    for (int i = 0; i < Courses.Length; i++)
        //    {
        //        if (Courses[i] == "react js")
        //        {
        //            Console.Write($"Your required name is: { Courses[i]}\n");
        //        }
        //    }
        //    for (int i = 0; i < Courses2.Length; i++)
        //    {
        //        if (Courses2[i] == "alina")
        //        {
        //            Console.Write("Your required name is: " + Courses2[i]);
        //        }
        //    }
        //}

        public void Change()
        {

        }
    }
}
