﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleName
{
    class Asset
    {
        private string Name;
        private int DefaultValue;
        private int MortgageValue;
        private int Ranking; //1 is browns
        private int CostOfHouse;
        private int NoOfHouses;
        private int Rent;
        public Asset(string _Name, int _DefaultValue, int _MortgageValue, int _Ranking)
        {
            Name = _Name;
            DefaultValue = _DefaultValue;
            MortgageValue = _MortgageValue;
            Ranking = _Ranking;
        }

        public Asset(string _Name, int _SubRank, int _Ranking)
        {
            Name = _Name;
            DefaultValue = _SubRank;
            Ranking = _Ranking;
        }
        public int CalcHouseCost()
        {
            // Calculates the cost of each house for the property (Use DefaultValue & Ranking)

            return 0;
        }

        public int CalcRent()
        {
            // Calculates the cost of the current rent (Use Ranking & NoOfHouses & DefaultValue)
            return 0;
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
