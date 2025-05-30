namespace BalancedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool isBalanced = true;
            int[] balanced_numbers = new int[0];

            do
            {
                int n = int.Parse(Console.ReadLine());

                if (n / 10 % 10 == n / 100 + n % 10)
                {
                    Array.Resize(ref balanced_numbers, balanced_numbers.Length + 1);
                    balanced_numbers[balanced_numbers.Length - 1] = n;
                }
                else
                {
                    isBalanced = false;
                }

            } while (isBalanced);

            foreach(int n in balanced_numbers)
            {
                sum += n;
            }

            Console.WriteLine("\n" + sum);
        }
    }
}