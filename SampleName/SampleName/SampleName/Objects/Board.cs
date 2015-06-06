using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SampleName
{
    class Board
    {
        private Asset[] Tiles;
        public Board(string FileName)
        {
            //Loads the board data from the file specified
            
            StreamReader StrmRdr = new StreamReader(FileName);
            List<Asset> Lst_Tiles = new List<Asset>();
            while (!StrmRdr.EndOfStream)
            {
                string line = StrmRdr.ReadLine();
                string[] values = line.Split(',');
                if (values[2].Equals(""))
                {
                    Asset tempAsset = new Asset(values[0], int.Parse(values[1]), int.Parse(values[3]));
                    Lst_Tiles.Add(tempAsset);
                }
                else
                {
                    Asset tempAsset = new Asset(values[0], int.Parse(values[1]), int.Parse(values[2]), int.Parse(values[3]));
                    Lst_Tiles.Add(tempAsset);
                }
            }
            Tiles = Lst_Tiles.ToArray();
        }
    }
}
