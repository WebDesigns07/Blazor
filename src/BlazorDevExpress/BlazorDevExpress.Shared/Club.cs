using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorDevExpress
{
    public class Club
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public string Coach { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
