using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblWorm.Bibl
{
    internal class Magazine : Item
    {
        public string issue { get; set; }
        public int year { get; set; }

        public override string DisplayInfo()
        {
            return $"Title: {title}, Issue: {issue}, Year: {year}, Inventory Number: {invNumber}, Available: {available}";
        }
    }
}
