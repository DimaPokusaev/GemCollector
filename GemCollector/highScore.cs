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
        public string difficulty;

        public HighScore(string _difficulty, int _time, int _clicks)
        {
            difficulty = _difficulty;
            time = _time;
            clicks = _clicks;
        }
    }
}
