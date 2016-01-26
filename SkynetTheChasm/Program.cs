using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        int road = int.Parse(Console.ReadLine()); // the length of the road before the gap.
        int gap = int.Parse(Console.ReadLine()); // the length of the gap.
        int platform = int.Parse(Console.ReadLine()); // the length of the landing platform.

        // game loop
        while (true)
        {
            int speed = int.Parse(Console.ReadLine()); // the motorbike's speed.
            int coordX = int.Parse(Console.ReadLine()); // the position on the road of the motorbike.
            if (coordX < road - 1) // Wait until you are just in front of the gap.
            {
                // As quickly as possible, reach the minimum speed to jump the gap (speed must be equal to gap + 1).
                if (speed < gap + 1)
                {
                    Console.WriteLine("SPEED");
                }
                else if (speed > gap + 1)
                {
                    Console.WriteLine("SLOW");
                }
                else
                {
                    Console.WriteLine("WAIT");
                }
            }
            else if (coordX == road - 1)
            {
                Console.WriteLine("JUMP");
            }
            else
            {
                Console.WriteLine("SLOW"); // Slow down until you stop.
            }
        }
    }
}