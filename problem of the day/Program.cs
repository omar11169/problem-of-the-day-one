using System.ComponentModel.DataAnnotations;

namespace problem_of_the_day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int black = 1;
            int white = 1;
            int height = 1;

            for (int i = 1; i < 100; i++)
            {
                if ((i % 2) == 0)

                    if (black >= i)
                    {
                        black = black - i;
                        height++;
                    }
                    else
                    {
                        break;
                    }
                
            }
                white--;
                height++;
            Console.WriteLine($"{height}");
        }
    }
}
