using System.Text;

namespace CrookedDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            Console.OutputEncoding = Encoding.UTF8;
            string N = Console.ReadLine();

            N = N.Replace("-", "");
            N = N.Replace(".", "");

            while (N.Length > 1)
            {
                for (int i = 0; i < N.Length; i++)
                {
                    sum += long.Parse(N.ToCharArray()[i].ToString());
                }

                N = sum.ToString();
                sum = 0;
            }

            Console.WriteLine(N);
        }
    }
}