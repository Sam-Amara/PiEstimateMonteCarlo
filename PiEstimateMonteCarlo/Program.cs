using System;
using System.Linq;


namespace PiEstimateMonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            var param = 0;

            if (args.Length == 0 || !int.TryParse(args[0], out param) || param <= 0)
            {
                Console.WriteLine("Invalid Paramater, try again!");
            }
            else
            {
                var PiEstimate = MonteCarloSimulation(param) * 4.0;

                Console.WriteLine($"Pi Estimate: {PiEstimate}");
                Console.WriteLine($"Error:       {Math.Abs(Math.PI - PiEstimate)}");
            }
            
        }

        static double MonteCarloSimulation(int coordsCount)
        {
            var coords = new Coord[coordsCount];
            var r = new Random();
            var count = 0;

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
