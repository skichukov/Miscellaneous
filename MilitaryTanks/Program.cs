using System.Text;

namespace MilitaryTanks
{
    internal class Program
    {
        enum Command {R, L, D, U}

        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Въведете последователност от ходове на танк с главни букви - R, L, D, U, без интервали:");
            String moves = Console.ReadLine();

            for(int i = 0; i < moves.Length; i++)
            {
                try
                {
                    string move = moves.Substring(i, 1);

                    switch(move)
                    {
                        case "R":
                            x += 1;
                            break;

                        case "L":
                            x -= 1;
                            break;

                        case "D":
                            y -= 1;
                            break;

                        case "U":
                            y += 1;
                            break;
                    }
                } catch (Exception e) {
                    Console.WriteLine("Низът съдържа невалидни символи или интервали!");
                    return;
                }
            }

            Console.WriteLine("\n({0}, {1})", x, y);
        }
    }
}