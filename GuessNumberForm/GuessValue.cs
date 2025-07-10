using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberForm
{
    public class GuessValue
    {
        
       public static List<int> ListValues(int length) // создаем лист со всеми возможными вариатами ответа
        {
            List<int> values = new List<int>();
            
            for (int i = 0; i < length; i++)
            {
                values.Add(i + 1);
            }
            return values;
        }
        
        public static int GetHalf(List<int> values) // по факту метод находит середину листа
        {
            int half = values.Count;
            half = half / 2; 
            return values [half]; 
        }
        public static List<int> RightListValues(List<int> list, int value)
        {
            List<int> nevList = new List<int>();
            for (int i =0; i < list.Count - value; i++) // длинна листа минус пололовина
            {
                nevList.Add(list[i + value]); // заполняем правую сторону листа
            }
            return nevList;
        }
        public static List<int> LeftListValues(List<int> list, int value)
        {
            List<int> nevList = new List<int>();
            for (int i = 0; i < list.Count - value; i++) // длинна листа минус пололовина
            {
                nevList.Add(list[i]); // заполняем левую сторону листа
            }
            return nevList;
        }

    }
}
