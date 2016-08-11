using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLabAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            baseballStatisticNames baseballStat = new baseballStatisticNames();
            baseballStat.RunBaseballStats();
            Console.ReadLine();
        }
    }
}
