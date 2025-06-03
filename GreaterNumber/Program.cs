namespace GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            string[] sub_numbers = first.Split(',');
            string[] numbers = second.Split(',');
            bool isChanged;

            for(int i = 0; i < sub_numbers.Length; i++)
            {
                isChanged = false;

                for(int j = Array.IndexOf(numbers, sub_numbers[i]) + 1;
                    j < numbers.Length; j++)
                {
                    if (int.Parse(numbers[j]) > int.Parse(sub_numbers[i]))
                    {
                        sub_numbers[i] = numbers[j];
                        isChanged = true;
                        break;
                    }
                }

                if(!isChanged)
                {
                    sub_numbers[i] = "-1";
                }
            }

            for(int i = 0; i < sub_numbers.Length - 1; i++)
            {
                Console.Write(sub_numbers[i] + ", ");
            }

            Console.Write(sub_numbers[sub_numbers.Length - 1]);
        }
    }
}