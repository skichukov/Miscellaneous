namespace HeaviestWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] letters =
            {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
            'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
            's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            int N = int.Parse(Console.ReadLine());
            string[] words = new string[N];
            int[] weights = new int[N];
            int max = 0;

            for (int i = 0; i < N; i++)
            {
                words[i] = Console.ReadLine();
                weights[i] = 0;

                for (int j = 0; j < words[i].Length; j++)
                {
                    string s = words[i].Substring(j, 1);
                    char current_letter = s.ToLower().ToCharArray()[0];
                    weights[i] += Array.IndexOf(letters, current_letter) + 1;
                }

                if (weights[i] > max)
                {
                    max = weights[i];
                }
            }

            Console.WriteLine(max + " " + words[Array.IndexOf(weights, max)]);
        }
    }
}