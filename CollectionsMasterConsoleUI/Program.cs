using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50

            int[] numbersArray = new int[50];
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            PopulateArray(numbersArray);


            //TODO: Print the first number of the array
            Console.WriteLine($"First number of the array: {numbersArray[0]}");
            //TODO: Print the last number of the array            
            Console.WriteLine($"Last number of the array: {numbersArray[numbersArray.Length - 1]}");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            ReverseArray(numbersArray);
            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(numbersArray);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbersArray);
            Console.WriteLine("Multiple of three set to 0:");
            NumberPrinter(numbersArray);
            Console.WriteLine("-------------------");

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Array.Sort(numbersArray);
            Console.WriteLine("Sorted numbers:");
            NumberPrinter(numbersArray);
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            

            //TODO: Print the capacity of the list to the console
            

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            

            //TODO: Print the new capacity
            

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable


            //TODO: Clear the list


            #endregion

            #region Lists

            Console.WriteLine("************Start Lists**************");

            
            List<int> numberList = new List<int>();

            
            Console.WriteLine($"List capacity: {numberList.Capacity}");

            
            PopulateList(numberList);

            
            Console.WriteLine($"List capacity after population: {numberList.Capacity}");

            Console.WriteLine("---------------------");

            
            Console.WriteLine("What number will you search for in the number list?");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int searchNumber))
            {
                NumberChecker(numberList, searchNumber);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");

            
            OddKiller(numberList);
            Console.WriteLine("Evens Only:");
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            
            numberList.Sort();
            Console.WriteLine("Sorted Evens:");
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            
            int[] newArray = numberList.ToArray();

            
            numberList.Clear();

            #endregion
        }

        private static void PopulateArray(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51); 
            }
        }

        private static void PopulateList(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 51)); 
            }
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(x => x % 2 != 0);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Number {searchNumber} is present in the list.");
            }
            else
            {
                Console.WriteLine($"Number {searchNumber} is not present in the list.");
            }
        }

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }

        private static void NumberPrinter(IEnumerable<int> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}