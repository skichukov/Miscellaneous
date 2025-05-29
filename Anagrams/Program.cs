namespace Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string W = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            string[] words = new string[N];
            bool isAnagram;

            for (int i = 0; i < N; i++)
            {
                words[i] = Console.ReadLine();
            }

            foreach (string word in words)
            {
                string sub_W = W;

                if(word == W || word.Length != W.Length)
                {
                    Console.WriteLine("No");
                    continue;
                }

                isAnagram = true;

                for(int i = 0; i < word.Length; i++)
                {
                    if (!sub_W.Contains(word.ToCharArray()[i]))
                    {
                        isAnagram = false;
                        break;
                    }

                    sub_W = sub_W.Remove(sub_W.IndexOf(word.ToCharArray()[i]), 1);
                }

                if (!isAnagram)
                {
                    Console.WriteLine("No");
                } else
                {
                    Console.WriteLine("Yes");
                }
            }
        }
    }
}