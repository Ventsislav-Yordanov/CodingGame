using System;
/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        // game loop
        while (true)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int spaceX = int.Parse(inputs[0]);
            int spaceY = int.Parse(inputs[1]);
            int maxHeight = int.MinValue;
            int maxIndex = 0;
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.
                if (mountainH > maxHeight)
                {
                    maxHeight = mountainH;
                    maxIndex = i;
                }
            }

            if (spaceX == maxIndex)
            {
                Console.WriteLine("FIRE");
            }
            else
            {
                Console.WriteLine("HOLD");
            }
        }
    }
}