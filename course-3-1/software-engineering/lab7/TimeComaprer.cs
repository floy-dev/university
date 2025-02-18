using System.Collections;

namespace lab7
{
    internal class TimeComaprer : IComparer
    {
        public int Compare(Object x, Object y)
        {
            if (x == null || y == null)
            {
                return -1;
            }

            Time? time1 = x as Time;
            Time? time2 = y as Time;

            return (int)(time2.ToSeconds() - time1.ToSeconds());
        }
    }
}
