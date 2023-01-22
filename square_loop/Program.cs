namespace square_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n <= 1 && n > 0)
            {
                Console.WriteLine("+");
            }
            else if (n <= 2 && n > 0)
            {
                Console.Write("++\n++");
            }
            else if (n > 2)
            {
                //First Row
                Console.Write("+");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" +");

                //Mid Row
                for (int row = 0; row < n - 2; row++)
                {
                    Console.Write("|");
                    for (int i = 0; i < n - 2; i++)
                    {
                        Console.Write(" -");
                    }
                    Console.WriteLine(" |");
                }

                //Last Row
                Console.Write("+");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" +");
            }
            else 
            {
                Console.WriteLine("T_T");
            }
        }
    }
}