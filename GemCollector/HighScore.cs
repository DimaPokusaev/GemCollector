using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemCollector
{
    public class HighScore
    {
        public int time, clicks;
        public string name, difficulty;

        public HighScore(string _difficulty, int _time, int _clicks, string _name)
        {
            difficulty = _difficulty;
            time = _time;
            clicks = _clicks;
            name = _name;
        }
    }
}
