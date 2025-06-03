// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Въведете цяло число от 2 до 1000:");
        int N;
        do
        {
            N = int.Parse(Console.ReadLine());

        } while (N < 2 || N > 1000);

        int[] numbers = new int[N];

        Console.WriteLine();
        Console.WriteLine("Въведете {0} двуцифрени числа без нули:", N);

        for (int i = 0; i < N; i++)
        {
            int num;

            do
            {
                num = int.Parse(Console.ReadLine());
            }
            while (!(num > 10 && num < 100 && num % 10 != 0));

            numbers[i] = num;
        }

        Console.WriteLine();
        Console.WriteLine("Отпечатване на обединени числа:");

        for (int i = 1; i < N; i++)
        {
            int j = numbers[i - 1] % 10;
            int k = numbers[i] / 10;
            int merged = j * 10 + k;

            Console.Write(merged + " ");
        }

        Console.WriteLine();

        for (int i = 1; i < N; i++)
        {
            int dm = numbers[i - 1] % 10 + numbers[i] / 10;

            if (dm >= 10)
            {
                dm %= 10;
            }

            string sqsh = "" + numbers[i - 1] / 10 + dm + numbers[i] % 10;
            Console.Write(sqsh + " ");
        }

        Console.WriteLine();
        Console.ReadKey();
    }
}