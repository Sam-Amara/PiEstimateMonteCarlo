using System;
using System.Linq;


namespace PiEstimateMonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            int param = 0;
            if (args.Length == 0 || !int.TryParse(args[0], out param) || param <= 0)
            {
                Console.WriteLine("Invalid Paramater, try again!");
            }
            else
            {
                double PiEstimate = MonteCarloSimulation(param) * 4;

                Console.WriteLine($"Pi Estimate is: {PiEstimate}");
                Console.WriteLine($"Error is: {Math.Abs(Math.PI - PiEstimate)}");
            }
            
        }

        static double MonteCarloSimulation(int coordsCount)
        {
            Coord[] coords = new Coord[coordsCount];
            Random r = new Random();
            int count = 0;

            double HypotenuseSquared(Coord xy) 
                => Math.Pow(xy.x, 2) + Math.Pow(xy.y, 2); 

            for(int i =0; i < coords.Length; i++)
            {
                coords[i] = new Coord(r);

                if(HypotenuseSquared(coords[i]) <= 1)
                {
                    count++;
                }
            }

            return (double)count / coords.Length;
        }

        
    }

    struct Coord
    {
        public double x;
        public double y;

        public Coord(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Coord(Random r)
        {
            this.x = r.NextDouble();
            this.y = r.NextDouble();
        }

    }
}
