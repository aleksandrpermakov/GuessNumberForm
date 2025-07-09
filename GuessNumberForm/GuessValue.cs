using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberForm
{
    public class GuessValue
    {
        public static int half = RandomRange.GetEndRange() /2;
       // public static List<int> values_ = new List<int>();   
        List<int> Values ()
        {
            List<int> values = new List<int>();
            int length = half * 2;
            for (int i = 0; i < length; i++)
            {
                values.Add(i);
            }
            return values;
        }
        
        public static int GuessNumber(int endRange,List<int> values)
        {
            int result = 0;
            if (result < half)
            {
                half = half / 2;
            }
            return result;
        }
    }
}
