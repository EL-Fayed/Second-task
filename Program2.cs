namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = new List<int>() { 5, 6, 7, 8, 9 };
            Console.Write("Enter the number to search for: ");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] == searchNumber)
                {
                    Console.WriteLine($"Number {searchNumber} found at index {i}.");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Number not found in the list.");
            }

        }
    }
}
