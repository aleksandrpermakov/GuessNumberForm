using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberForm
{
    public class RandomRange
    {
        static int beginRange = 1;
        public int GetBeginRange()
        {
            return  beginRange;
        }

        public static int GetEndRange()
        {
            Random endRange = new Random();
           return endRange.Next( 10, 100);
    
        }
    }
}
