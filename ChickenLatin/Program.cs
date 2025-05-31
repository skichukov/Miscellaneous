namespace ChickenLatin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            char[] vowels = {'a', 'e', 'i', 'o', 'u',
                                'A', 'E', 'I', 'O', 'U'};
            int l;

            for (int i = 0; i < words.Length; i++)
            {
                l = words[i].Length;

                if (vowels.Contains(words[i].ElementAt(0)))
                {
                    string s = words[i].ElementAt(0).ToString();
                    words[i] = words[i].Substring(1) + s + "che";
                }
                else
                {
                    words[i] += "che";
                }

                if(l % 2 == 0)
                {
                    words[i] += "e";
                }

                Console.Write(words[i] + " ");
            }
        }
    }
}