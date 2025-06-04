namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] prime_numbers = { 1 };
            bool isPrime;

            for(int i = 2; i <= N; i++) {

                isPrime = true;

                for(int j = 2; j <= i/2; j++) {

                    if(i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if( isPrime )
                {
                    Array.Resize(ref prime_numbers, prime_numbers.Length + 1);
                    prime_numbers[prime_numbers.Length - 1] = i;
                }
            }

            for(int i = 0; i < prime_numbers.Length; i++)
            {
                for(int j = 1; j <= prime_numbers[i]; j++)
                {
                    if(prime_numbers.Contains(j))
                    {
                        Console.Write(1);
                    }
                    else {
                        Console.Write(0);
                    }
                }

                Console.WriteLine("");
            }
        }
    }
}