namespace PowerOfThor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Player
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int lightX = int.Parse(inputs[0]); // the X position of the light of power
            int lightY = int.Parse(inputs[1]); // the Y position of the light of power
            int initialTX = int.Parse(inputs[2]); // Thor's starting X position
            int initialTY = int.Parse(inputs[3]); // Thor's starting Y position
            string[] directions = new[] { "N", "NE", "E", "SE", "S", "SW", "W", "NW" };
            double[] directionAngles = new[] { Math.PI / 2, Math.PI / 4, 0, -Math.PI / 4, -Math.PI / 2, -3 * Math.PI / 4, Math.PI, 3 * Math.PI / 4 };
            var deltaCoordinates = new Tuple<int, int>[] 
            {
                new Tuple<int, int>(0, -1),
                new Tuple<int, int>(1, -1),
                new Tuple<int, int>(1, 0),
                new Tuple<int, int>(1, 1),
                new Tuple<int, int>(0, 1),
                new Tuple<int, int>(-1, 1),
                new Tuple<int, int>(-1, 0),
                new Tuple<int, int>(-1, -1)
            };
            // game loop
            while (true)
            {
                int remainingTurns = int.Parse(Console.ReadLine());
                int deltaX = lightX - initialTX;
                int deltaY = -(lightY - initialTY);
                var angle = Math.Atan2(deltaY, deltaX);
                double[] differences = directionAngles.Select(d => Math.Abs(angle - d)).ToArray();
                double minValue = double.MaxValue;
                int minIndex = 0;
                for (int i = 0; i < differences.Length; i++)
                {
                    if (differences[i] < minValue)
                    {
                        minValue = differences[i];
                        minIndex = i;
                    }
                }

                Console.WriteLine(directions[minIndex]);
                initialTX += deltaCoordinates[minIndex].Item1;
                initialTY += deltaCoordinates[minIndex].Item2;
            }
        }
    }
}
