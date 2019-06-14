using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemCollector
{
    public class GridBox
    {
        public int size = 40;
        public int x, y;
        public string value;
        public string appearence = "Invisible";

        public GridBox(int _x, int _y, string _value)
        {
            x = _x;
            y = _y;
            value = _value;
        }

        public void AddGem()
        {
            // T and B gems are same gems but at the top and bottom of the screen, this information is needed for future use
            // T and B gems are used for determining when a column ends when generating numbers and opening up spaces
            if (y == 0)
            {
                value = "TGem";
            }
            else if (y == SelectScreen.GridHeight - 1)
            {
                value = "BGem";
            }
            else
            {
                value = "Gem";
            }
        }
    }
}
