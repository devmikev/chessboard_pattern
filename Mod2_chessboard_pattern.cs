namespace Mod2_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
    // Create the pattern of a chess board that is 8 x 8. Use X and O to represent the squares.
            string row = "";
            bool pattern = true;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (pattern)
                        row += "XO";
                    else
                        row += "OX";
                }
                Console.WriteLine(row);
                pattern = !pattern;
                row = "";
            }
        }
    }
}