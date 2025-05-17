using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    public class Staff
    {
        public string Name { get; set; }
        public bool IsZookeeper { get; set; }
        public bool IsVet { get; set; }

        public Staff(string name, bool isZookeeper, bool isVet)
        {
            Name = name;
            IsZookeeper = isZookeeper;
            IsVet = isVet;
        }
    }
}
