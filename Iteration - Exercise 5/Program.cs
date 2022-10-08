using System;
using System.Linq;

namespace Iteration___Exercise_5
{
    public class Program
    {
        public static void Main(string[] args)

        {
            //5- Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console.
            //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.WriteLine("Please enter a series of numbers, each seperated by a comma.");    //will need to account for whitespace or no whitespace between comma & numeric values - maybe in build 2.0)

            string readStringUserInput = Console.ReadLine();
            int maximumValue = CalculatMaxValue(readStringUserInput);
            Console.WriteLine($"Maximum value is {maximumValue}");

            //works, but due to length stops when maximumValue hits 5 (from example 1,2,3,4,5) eg 1,5,2,3,4 will stop iterating at point 1 (5) // this is crap! stops after counting items in array, not max value
        }

        public static int CalculatMaxValue(string readStringUserInput)
        {
            if (readStringUserInput.Length == 0) return 0;

            //return readStringUserInput.Split(',').Select(str => Convert.ToInt32(str.Trim())).Max();

            string[] stringUserInput = readStringUserInput.Split(',');
            //convert string array values to int - use loop to input/convert
            int[] intUserInput = new int[stringUserInput.Length];

            for (int stringArrayPosition = 0; stringArrayPosition < stringUserInput.Length; stringArrayPosition++) //recheck 
            {
                string currentValueOfStringArray = stringUserInput[stringArrayPosition];
                currentValueOfStringArray = currentValueOfStringArray.Trim();
                int currentIntegerValueOfStringArray = Convert.ToInt32(currentValueOfStringArray);
                intUserInput[stringArrayPosition] = currentIntegerValueOfStringArray;
            }

            int maximumValue = int.MinValue;
            foreach (int integerInTheArray in intUserInput)
            {
                if (integerInTheArray > maximumValue)
                {
                    maximumValue = integerInTheArray;
                }
            }

            return maximumValue;
        }
    }
}
