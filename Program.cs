using System;

namespace Star_tree
{
    class Program
    {

        static void DrawPyramid(int lines)
        {
            lines = (lines > 115) ? 115 : lines;

            int i = 0; // counter
            int middle = 0; // middle position for first star

            int s; // variable for find middle pozition for first star
            for (s = 1; i < lines; ++i, s += 2)
                ;
            middle = (s - 2) / 2;

            for (s = 1, i = 0; i < lines; ++i, Console.WriteLine())
            {
                for (int j = 0; j < middle; ++j)
                    Console.Write(' ');
                --middle;

                for (int j = 0; j < s; ++j)
                    Console.Write('*');
                s += 2;
            }
        }
        static void Main(string[] args)
        {
            /* Input a tree */
            Console.Write("Input count of lines: ");
            Console.WriteLine();
            do
            {
                try
                {
                    DrawPyramid(checked(Convert.ToInt32(Console.ReadLine())));
                    break;
                }
                catch
                {
                    Console.WriteLine("You wrote wrong statement. Please, try again!");
                }
            } while (true);
            Console.WriteLine();
            Console.WriteLine("Cheers holiday!");
            /****************/

            Console.ReadKey(); // waiting finish input
        }
    }
}
