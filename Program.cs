namespace assignment1_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input the number of elements to store in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine($"Input {n} number of elements in the array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"element - {i} : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The values stored into the array are:");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("\nThe values stored into the array in reverse are:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i] + " "); 
            }




        }
    }
}
