using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesement3
{
    public class CricketTeam
    {
        public string TeamName { get; set; }
        public int Matches { get; set; }
        public int Sum { get; set; }
        public double Average { get; set; }

        public(int,int,double)PointsCalculation(int no_of_matches)
        {
            Sum = 0;
            for(int i=1;i<= no_of_matches; i++)
            {
                Console.WriteLine($"Enter score of match{i}:");
                Sum += int.Parse(Console.ReadLine());
            }
            Matches = no_of_matches;
            Average = (double)Sum / no_of_matches;
            return (Matches, Sum, Average);
        }
    }
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter team name:");
            string team = Console.ReadLine();
            CricketTeam t = new CricketTeam();
           
            Console.WriteLine("Enter number of matches:");
            int no_of_matches = int.Parse(Console.ReadLine());
            var (matches, sum, avg) = t.PointsCalculation(no_of_matches);
            Console.WriteLine($"Team:{team},Matches:{matches},Sum:{sum},Average:{avg}");
            Console.Read();
        }
        
    }
}
