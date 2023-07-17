namespace ArraySample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 10, 30, 50, 90, 01 };

            foreach (int w in arr)
            {
                Console.WriteLine("Total Elements: " + w);
            }
            Console.WriteLine("-----------------------------");


            Console.WriteLine("Array Length: " + arr.Length);

            Console.WriteLine("-----------------------------");

            Console.WriteLine("Maximum number is: " + arr.Max());
            Console.WriteLine("Minimum number is: " + arr.Min());
            


            Console.WriteLine("----------Sorted-------------------");

            Array.Sort(arr);

            foreach (int j in arr)
            {
                Console.WriteLine("Array Sort: " + j);
            }
            Console.WriteLine("----------Reverse-------------------");

            Array.Reverse(arr);

            foreach (int t in arr)
            {
                Console.WriteLine("Sorted Array Reverse: " + t);
            }
        }
    }
}    
