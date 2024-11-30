using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BiblWorm.Bibl
{
    internal abstract class Item : IPubs, IComparable<Item>
    {
        public string title { get; set; }
        public int invNumber { get; set; }
        public bool available { get; set; }
        public int periodUse { get; set; }

        public abstract string DisplayInfo();

        public int CompareTo(Item other)
        {
            return invNumber.CompareTo(other.invNumber);
        }

    }
}
