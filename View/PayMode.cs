using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.View
{
    internal class PayMode
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Observation { get; set; }

        public PayMode(int? id, string name, string observation)
        {
            Id = id;
            Name = name;
            Observation = observation;
        }
    }
}
