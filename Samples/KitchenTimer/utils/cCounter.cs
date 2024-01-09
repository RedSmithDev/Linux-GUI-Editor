using System;
namespace KitchenTimer
{
    public class cCounterHelper
    {
        public cCounterHelper()
        {
        }

        int seconds = 9;
        int minutes = 0;
        int hours = 0;

        public void reset()
        {
            seconds = 0;
            minutes = 0;
            hours = 0;
        }

        public bool isEqual(string tA,string tB)
        {
            if(tA == tB)
            {
                return true;
            }
            return false;
        }

        private string format(int _num)
        {
            string snum = _num.ToString();
            if(snum.Length == 1)
            {
                snum = "0" + snum;
            }
            return snum;
        }

        public string get()
        {
            seconds++;
            if (seconds > 59)
            {
                seconds = 0;
                minutes++;
            }
            if (minutes > 59)
            {
                minutes = 0;
                hours++;
            }

            return format(hours) + ":" + format(minutes) + ":" + format(seconds);
        }

    }
}
