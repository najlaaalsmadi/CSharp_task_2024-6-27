using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _26._06._2024_CSharp_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	Write a C# program that accept two integers and display the smaller. 
            Console.WriteLine("input number1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input number2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 < num2)
            {
                Console.WriteLine("the smaller number=" + num1);
            }
            else
            {
                Console.WriteLine("the smaller number=" + num2);

            }
            //2.Write a C# conditional statement to find the sign  of input  number.
            //    Display sign. Go 
            //        •	Sample numbers: -7
            //        •	Output: The sign is -

            Console.WriteLine("input number sign  of=");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("The sign is=" + "(+)" + num);
            }
            else
            {
                Console.WriteLine("The sign is=" + "(-)" + num);

            }
            //3.Write a C# conditional statement to sort three numbers ascending. Use console to display the result.
            //       •	Sample numbers: 0, -1, 4
            //       •	Output: 4, 0, -1
            Console.WriteLine("input number one sort three numbers ascending=");

            int num_sort1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input number two sort three numbers ascending=");

            int num_sort2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input number three sort three numbers ascending=");

            int num_sort3 = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[] { num_sort1, num_sort2, num_sort3 };
            Array.Sort(arr);
            Console.Write("Output for loop numbers ascending:");
            int i = arr.Length - 1;
            int j = 0;
            for (; i >= 0; i--)
            {
                Console.Write(" " + arr[i]);
            }
            Array.Reverse(arr);
            Console.WriteLine();
            Console.Write("Output for print  numbers ascending:");
            Console.Write(arr[0]);
            Console.Write(" " + arr[1]);
            Console.Write(" " + arr[2]);


            //4.Write a C# conditional statement to find the max of five numbers. Use console to display the result.
            //       •	Sample numbers: -5, -2, -6, 0, -1
            //       •	Output: 0
            Console.WriteLine("\n");

            int num_max1 = Convert.ToInt32(Console.ReadLine());
            int num_max2 = Convert.ToInt32(Console.ReadLine());
            int num_max3 = Convert.ToInt32(Console.ReadLine());
            int num_max4 = Convert.ToInt32(Console.ReadLine());
            int num_max5 = Convert.ToInt32(Console.ReadLine());
            int[] arr_Max = new int[] { num_max1, num_max2, num_max3, num_max4, num_max5 };
            int max1 = arr_Max.Max();
            Console.WriteLine("The Max number=" + max1);
            //Write a C# program that converts kilometers per hour to miles per hour.  
            //  Expected Output:
            //     •	Input kilometers per hour: 15.
            //     •	9.320568 miles per hour
            //15 km = 15 × 0.6213711922 mi, mi (Int) = 9.3205678836
            Console.WriteLine("Input kilometers per hour:");
            int kilometers = Convert.ToInt32(Console.ReadLine());
            double miles = kilometers * 0.6213711922;
            Console.WriteLine(miles + "miles per hour");


            /*6.	Write a C# program that takes hours and minutes as input and calculates the total number of minutes.
                   •	Input hours: 5
                   •	Input minutes: 37
                   •	Total: 337 minutes.
             ساعة يساوي 60 دقيقة 
            */
            Console.WriteLine("Input hours:");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            int hours_in_minutes = hours * 60;
            int total_minutes = hours_in_minutes + minutes;
            Console.WriteLine("Total:" + total_minutes + " minutes.");

            /*7.	Write a program in C# that takes minutes as input and display the total number of hours and minutes. 
                 •	Input minutes: 546
                 •	9 Hours, 6 Minutes
            */
            Console.WriteLine("Input minutes:");
            int minutes2 = Convert.ToInt32(Console.ReadLine());
            int minutes_hours1 = minutes2 / 60;
            int minutes_hours2 = minutes2 % 60;
            Console.WriteLine(minutes_hours1 + "Hours  " + minutes_hours2 + "Minutes");
            //8.Create string of array that contains 5 element of different sentence with different length.
            //    Print all elements with fixed length for each sentence.
            Console.WriteLine("Input sentence1:");
            string string_Value1 = Console.ReadLine();
            Console.WriteLine("Input sentence2:");
            string string_Value2 = Console.ReadLine();
            Console.WriteLine("Input sentence3:");
            string string_Value3 = Console.ReadLine();
            Console.WriteLine("Input sentence4:");
            string string_Value4 = Console.ReadLine();
            Console.WriteLine("Input sentence5:");
            string string_Value5 = Console.ReadLine();

            string[] arr_sentence = new string[] { string_Value1, string_Value2, string_Value3, string_Value4, string_Value5 };
            int fixedLength = 5;
            string FormatSentence(string sentence)
            {
                return sentence.Length > fixedLength
                    ? sentence.Substring(0, fixedLength)
                    : sentence.PadRight(fixedLength);
            }

            Console.WriteLine(FormatSentence(arr_sentence[0]));
            Console.WriteLine(FormatSentence(arr_sentence[1]));
            Console.WriteLine(FormatSentence(arr_sentence[2]));
            Console.WriteLine(FormatSentence(arr_sentence[3]));
            Console.WriteLine(FormatSentence(arr_sentence[4]));









            Console.ReadLine();
        }
    }
}


