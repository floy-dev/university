using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Utils
{
    [Serializable]
    public class Time
    {
        private uint _h, _m, _s;

        public uint Hours
        {
            get => _h;
            set
            {
                if (value > 23) throw new ArgumentException("Часы должны быть от 0 до 23");
                _h = value;
            }
        }

        public uint Minutes
        {
            get => _m;
            set
            {
                if (value > 59) throw new ArgumentException("Минуты должны быть от 0 до 59");
                _m = value;
            }
        }

        public uint Seconds
        {
            get => _s;
            set
            {
                if (value > 59) throw new ArgumentException("Секунды должны быть от 0 до 59");
                _s = value;
            }
        }

        public Time(uint hours = 0, uint minutes = 0, uint seconds = 0)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Time(uint hours = 0, uint minutes = 0)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = 0;
        }

        public Time(uint hours = 0)
        {
            Hours = hours;
            Minutes = 0;
            Seconds = 0;
        }

        public Time(Time other) : this(other._h, other._m, other._s)
        {
        }

        public void Display()
        {
            Console.WriteLine(ToString());
        }

        public uint ToSeconds() => _h * 3600 + _m * 60 + _s;

        public double ToMinutes() => _h * 60 + _m + _s / 60.0;

        public static int DifferenceInSeconds(Time t1, Time t2)
        {
            return Math.Abs((int)t1.ToSeconds() - (int)t2.ToSeconds());
        }

        public static Time operator +(Time t, int seconds)
        {
            var totalSeconds = (uint)(t.ToSeconds() + seconds);

            return FromSeconds(totalSeconds);
        }

        public static Time operator -(Time t, int seconds)
        {
            var totalSeconds = (int)t.ToSeconds() - seconds;

            if (totalSeconds < 0)
            {
                totalSeconds = 0;
            }

            return FromSeconds((uint)totalSeconds);
        }

        public static Time operator ++(Time t1)
        {
            var seconds = t1.ToSeconds() + 1;

            return FromSeconds(seconds);
        }

        public static Time operator --(Time t1)
        {
            var seconds = t1.ToSeconds() - 1;

            return FromSeconds(seconds);
        }

        public static bool operator >(Time t1, Time t2) => t1.ToSeconds() > t2.ToSeconds();

        public static bool operator <(Time t1, Time t2) => t1.ToSeconds() < t2.ToSeconds();

        public static bool operator >=(Time t1, Time t2) => t1.ToSeconds() >= t2.ToSeconds();

        public static bool operator <=(Time t1, Time t2) => t1.ToSeconds() <= t2.ToSeconds();

        public static bool operator true(Time t) => t.ToSeconds() > 0;

        public static bool operator false(Time t) => t.ToSeconds() == 0;

        public override string ToString()
        {
            return $"{_h:D2}:{_m:D2}:{_s:D2}";
        }

        private static Time FromSeconds(uint totalSeconds)
        {
            var hours = (totalSeconds / 3600) % 24;
            var minutes = (totalSeconds / 60) % 60;
            var seconds = totalSeconds % 60;

            return new Time(hours, minutes, seconds);
        }
    }
}
