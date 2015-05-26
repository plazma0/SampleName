using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleName.Objects
{
    class Asset
    {
        private static string Name;
        private static int DefaultValue;
        private static int MortgageValue;
        private static int Ranking; //1 is browns
        private static int CostOfHouse;
        private int NoOfHouses;
        private int Rent;
        public void Asset(string _Name, int _DefaultValue, int _MortgageValue, int _Ranking)
        {
            Name = _Name;
            DefaultValue = _DefaultValue;
            MortgageValue = _MortgageValue;
            Ranking = _Ranking;
        }

        public int CalcHouseCost()
        {
            // Calculates the cost of each house for the property (Use DefaultValue & Ranking)
        }

        public int CalcRent()
        {
            // Calculates the cost of the current rent (Use Ranking & NoOfHouses & DefaultValue)
        }

        public void Sell()
        {
            // Sells the asset
        }

        public void Buy()
        {
            // Buys the asset
        }
    }
}
