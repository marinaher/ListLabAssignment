using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLabAssignment
{
    public class baseballStatisticNames
    {
        List<string> baseballStatName = new List<string>() { "Games played", "Plate Apperances", "At Bat", "Runs Scored", "Hits", "Double Hit", "Triple Hit", "Home Run" };
        List<int> statNumbers = new List<int>() { 113, 493, 426, 70, 112, 25, 0, 31 };

        public void RunBaseballStats()
        {
            var baseballStatNameAndstatNumbers = baseballStatName.Zip(statNumbers, (first, second) => first + ":    " + second);
            foreach (var item in baseballStatNameAndstatNumbers)
            Console.WriteLine(item);
        }
    }
}
