namespace Mod2_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
    // Create the pattern of a chess board that is 8 x 8. Use X and O to represent the squares.
            string row = "";
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                    row += i % 2 == 0 ? "XO" : "OX";
                Console.WriteLine(row);
                row = "";
            }
        }
    }
}