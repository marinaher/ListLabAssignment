using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLabAssignment
{
    public class baseballStatisticNames
    {

        List<string> baseballStatNames = new List<string>() {"At Bat: ", "Runs: ", "Hits:", "Doubles: ", "Triples:", "Home runs:"};
        List<double> statNumbers = new List<double>();

        public void runBaseballStats()
        {
            Console.WriteLine("Please enter in player statistics for: ");
            for (int i = 0; i < baseballStatNames.Count; i++)
            {
                Console.WriteLine(baseballStatNames[i]);
                statNumbers.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }
        public void RunStatNumbers()
        {
            Console.WriteLine("\nStatistics entered in for: ");
            for (int i = 0; i < statNumbers.Count; i++)
            {
                Console.WriteLine("- " + baseballStatNames[i] + " \t" + statNumbers[i] );
            }
        }
    }
}