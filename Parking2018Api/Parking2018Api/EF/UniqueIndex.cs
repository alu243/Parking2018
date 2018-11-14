using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking2018Api.EF
{
    public class UniqueIndex : Attribute
    {
        public string IndexName { get; set; }
        public int Position { get; set; }

        public UniqueIndex(string ixName)
        {
            this.IndexName = ixName;
            this.Position = 1;
        }

        public UniqueIndex(string ixName, int position)
        {
            this.IndexName = ixName;
            this.Position = position;
        }
    }
}
