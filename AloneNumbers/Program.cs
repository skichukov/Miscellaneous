namespace AloneNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int trg = int.Parse(Console.ReadLine());
            string[] numbers = s.Split(',');
            string changed = "[" + numbers[0] + ", ";

            for (int i = 1; i < numbers.Length - 1; i++)
            {

                if (int.Parse(numbers[i]) != trg)
                {
                    changed += numbers[i] + ", ";
                    continue;
                }

                if (numbers[i - 1] == numbers[i]
                    || numbers[i] == numbers[i + 1])
                {
                    changed += numbers[i] + ", ";
                    continue;
                }

                if (int.Parse(numbers[i - 1]) >
                    int.Parse(numbers[i + 1]))
                {
                    numbers[i] = numbers[i - 1];
                }
                else
                {
                    numbers[i] = numbers[i + 1];
                }

                changed += numbers[i] + ", ";
            }

            changed += numbers[numbers.Length - 1] + "]";

            Console.Write("[");

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write(numbers[i] + ", ");
            }

            Console.WriteLine(numbers[numbers.Length - 1] + "]");
        }
    }
}