using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //        P - Print numbers
            //A - Add a number
            //M - Display mean of the numbers
            //S - Display the smallest number
            //L - Display the largest number
            //Q - Quit
            int number;
            char selction;
            int min, max;
            bool duplicate;
            List<int> listOfNumbers = new List<int>();
            do
            {


                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("C - Clear the list");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("G -Sort the number ASC");
                Console.WriteLine("J-Sort the number DESC");
                Console.WriteLine("Q - Quit");
                Console.Write("Enter your choice: ");
                selction = Convert.ToChar(Console.ReadLine());

                switch (selction)
                {
                    // Add numbers 
                    case 'a':
                    case 'A':
                        if (true)
                        {

                            Console.Write("Enter the number : ");
                            number = Convert.ToInt32(Console.ReadLine());
                            duplicate = false;
                            for (int i = 0; i < listOfNumbers.Count; i++)
                            {
                                if (listOfNumbers[i] == number)
                                {
                                    duplicate = true;
                                    break;
                                }
                            }
                            if (!duplicate)
                            {
                                listOfNumbers.Add(number);
                                Console.Write($"The number {number} was added successfully.");
                            }
                            else
                                Console.WriteLine("The number is already exist in the list.");
                        }
                        else
                            Console.WriteLine("Please Enter a valid number");


                        break;
                    // print numbers
                    case 'p':
                    case 'P':
                        if (listOfNumbers.Count > 0)
                        {
                            Console.Write("[ ");
                            for (int j = 0; j < listOfNumbers.Count; j++)
                                Console.Write($" {listOfNumbers[j]} ");
                            Console.Write(" ]");
                        }
                        else
                            Console.WriteLine("The list is Empty.");

                        break;
                    // mean of numbers
                    case 'm':
                    case 'M':
                        if (listOfNumbers.Count > 0)
                        {
                            int sum = 0;
                            for (int j = 0; j < listOfNumbers.Count; j++)
                                sum += listOfNumbers[j];
                            Console.WriteLine($"The mean of numbers is : {sum / listOfNumbers.Count}");
                        }
                        else
                            Console.WriteLine("The List is Empty");
                        break;
                    // the smallest number
                    case 's':
                    case 'S':
                        if (listOfNumbers.Count > 0)
                        {
                            min = listOfNumbers[0];
                            for (int j = 1; j < listOfNumbers.Count; j++)
                                if (listOfNumbers[j] < min)
                                    min = listOfNumbers[j];
                            Console.WriteLine($"The Smallest number is : {min}");
                        }
                        else
                            Console.WriteLine("The List is Empty");
                        break;
                    // the Largest number
                    case 'l':
                    case 'L':
                        if (listOfNumbers.Count > 0)
                        {
                            max = listOfNumbers[0];
                            for (int j = 1; j < listOfNumbers.Count; j++)
                                if (listOfNumbers[j] > max)
                                    max = listOfNumbers[j];
                            Console.WriteLine($"The Largest number is : {max}");
                        }
                        else
                            Console.WriteLine("The List is Empty");
                        break;
                    //Smallest and Largest Number 
                    // case 's':
                    // case 'S':
                    // case 'l':
                    // case 'L':
                    //     if (listOfNumbers.Count > 0)
                    //     {
                    //         min = max = listOfNumbers[0]; 
                    //         for (int j = 1; j < listOfNumbers.Count; j++)
                    //             if (listOfNumbers[j] < min) 
                    //                 min = listOfNumbers[j];
                    //             if (listOfNumbers[j] > max) 
                    //                 max = listOfNumbers[j];
                    //         if (selction == 'S' || selction == 's')
                    //             Console.WriteLine($"The Smallest number is: {min}");
                    //         else
                    //             Console.WriteLine($"The Largest number is: {max}");
                    //     }
                    //     else
                    //         Console.WriteLine("The List is Empty");
                    //     break;

                    // Sort the numbers ASC & DESC by swaping 
                    case 'g':
                    case 'G':
                    case 'j':
                    case 'J':
                        if (listOfNumbers.Count > 0)
                        {
                            for (int i = 0; i < listOfNumbers.Count; i++)
                            {
                                for (int j = i + 1; j < listOfNumbers.Count; j++)
                                {
                                    bool condition;
                                    if (selction == 'G' || selction == 'g')
                                        condition = listOfNumbers[i] > listOfNumbers[j];  //ASC
                                    else
                                        condition = listOfNumbers[i] < listOfNumbers[j];  // DESC
                                    if (condition)
                                    {
                                        int swap = listOfNumbers[i];
                                        listOfNumbers[i] = listOfNumbers[j];
                                        listOfNumbers[j] = swap;
                                    }
                                }
                            }
                            Console.Write("[ ");
                            for (int j = 0; j < listOfNumbers.Count; j++)
                                Console.Write($" {listOfNumbers[j]} ");
                            Console.Write(" ]");
                        }
                        else
                            Console.WriteLine("The List is Empty");
                        break;
                    case 'q':
                    case 'Q':
                        Console.WriteLine("Good Bye");
                        break;
                    case 'c':
                    case 'C':
                        if (listOfNumbers.Count > 0)
                        {
                            listOfNumbers.Clear();
                            Console.WriteLine("The list is cleared successfully.");
                        }
                        else
                            Console.WriteLine("The List is Empty");
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;

                }

            } while (selction != 'Q' && selction != 'q');





            Console.ReadLine();
        }
    }
}
