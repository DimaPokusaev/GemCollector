using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemCollector
{
    public class SavedGrid
    {
        public List<GridBox> Grid;
        public string name;

        public SavedGrid(List<GridBox> _Grid, string _name)
        {
            Grid = _Grid;
            name = _name;
        }

        public void OnLoad()
        {
            foreach (GridBox b in Grid) // covers the entire grid
            {
                b.appearence = "Invisible";
            }

            int yFinder = 0;
            int xFinder = 0;
            int GemFinder = 0;
            foreach (GridBox b in Grid)
            {
                // Determines the dimention and number of gems
                b.appearence = "Invisible";
                if (xFinder < b.x)
                {
                    xFinder = b.x;
                }
                if (yFinder < b.y)
                {
                    yFinder = b.y;
                }
                if ((b.value == "Gem") || (b.value == "TGem") || (b.value == "BGem"))
                {
                    GemFinder++;
                }
            }
            SelectScreen.GridWidth = xFinder + 1;
            SelectScreen.GemNum = GemFinder;
            SelectScreen.GridHeight = yFinder + 1;
        }
    }
}
