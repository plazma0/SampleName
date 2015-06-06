using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleName
{
    class Player
    {
        private static int ID;
        private static string Name;
        private static Class Class;
        private int Balance;
        private Asset[] Assets;
        private List<Item> Items;
        public Player(int _ID)
        {
            ID = _ID;
        }
        
        public void GiveItem(Item TargetItem) //Gives the player a target item
        {
            Items.Add(TargetItem);
        }

        public void TakeItem(Item TargetItem) //Takes a target item from the player
        {
            Items.Remove(TargetItem);
        }
    }
}
