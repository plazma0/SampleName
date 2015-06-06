using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleName
{
    class Item
    {
        private static string Name;
        private static bool Type; //Y for Community Chest, N for Chance
        public Item(string _Name, bool _Type)
        {
            Name = _Name;
            Type = _Type;
        }
    }
    
    class ExampleItem : Item //ExampleItem : Item ---- ExampleItem inherits from Item
    {
        public ExampleItem(string _Name, bool _Type)
            : base(_Name, _Type)
        { }
        public void Use()
        {
            //Action to perform when ExampleItem is used
        }
    }
}
