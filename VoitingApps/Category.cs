using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitingApps
{
    class Category
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        public Category(string name)
        {
            Name = name;
            Votes = 0;
        }
    }
}
