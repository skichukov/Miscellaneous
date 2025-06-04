using System.Text;

namespace TitleSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            String title = "";
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Въведете низ - заглавие с малки латински букви [a-z]:");

            do {
                title.Remove(0);
                title = Console.ReadLine();
            }
            while(title.Length < 7 || title.Length > 5000);

            foreach(char c in title) {
                if(c == ' ')
                {
                    continue;
                }

                if('a' > c || c > 'z')
                {
                    throw new Exception("Заглавието трябва да съдържа само малки латински букви.");
                }

                continue;
            }

            Console.Write("\n");

            do
            {
                Console.Write("Въведете цяло число от 3 до 10: ");
                N = int.Parse(Console.ReadLine());
            }
            while (N < 3 || N > 10);

            Console.WriteLine("\nВъведете {0} низа, след което заглавието ще бъде променяно:", N);

            string[] parts = new string[N];
            string[] changes = new string[N];
            string fPart;
            string sPart;

            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = Console.ReadLine();
                string temp = title;
                bool isFound = true;
                int k = 0;

                for (int j = 0; j < parts[i].Length; j++)
                {
                    if (!temp.Substring(k).Contains(parts[i].ElementAt(j))) {
                        changes[i] = "Не е намерено такова заглавие!";
                        isFound = false;
                        break;
                    }

                    k = temp.IndexOf(parts[i].ElementAt(j), k);
                    fPart = temp.Substring(0, k);
                    sPart = temp.Substring(k + 1);
                    temp = fPart + sPart;
                }

                if(isFound) {

                    title = temp;
                    changes[i] = title;
                }
            }

            Console.Write("\n");

            for(int i = 0; i < changes.Length;  i++)
            {
                Console.WriteLine(changes[i]);
            }
        }
    }
}