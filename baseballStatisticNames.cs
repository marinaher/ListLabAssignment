﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLabAssignment
{
    public class baseballStatisticNames
    {
        public baseballStatisticNames()
        {
            List<string> baseballStatistic = new List<string>();
            baseballStatistic.Add("batting");
            baseballStatistic.Add("baserunning");
            baseballStatistic.Add("pitching");
            baseballStatistic.Add("fielding");
            baseballStatistic.Add("overall player value");
            baseballStatistic.Add("general");

            foreach (string baseballStat in baseballStatistic)
            {
                Console.WriteLine(baseballStat);
            }
        }
    }
}