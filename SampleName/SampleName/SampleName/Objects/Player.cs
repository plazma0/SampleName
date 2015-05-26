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
        private int Balance;
        private Objects.Asset[] Assets;
        public Player(int _ID)
        {
            ID = _ID;
        }
    }
}
