using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAPI
{
    internal class Transfer
    {
        public int ID { get; set; }
        public Account source { get; set; }
        public Account target { get; set; }

        public int amount { get; set; }
        public string title { get; set; }

        public DateTime timeStamp { get; set; }
    }
}
