using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowItemSetLibrary
{
    public class SetBonus
    {
        public string description { get; set; }
        public int threshold { get; set; }
    }

    public class RootObject
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<SetBonus> setBonuses { get; set; }
        public List<int> items { get; set; }
    }
}
