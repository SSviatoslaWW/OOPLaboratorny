using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna__9
{
    internal class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Time()
        {
            hours=minutes=seconds=0;
        }

        public Time(int hours, int minutes, int seconds)
        {
            correctHours(hours);
            correcrMinutes(minutes);
            correctSeconds(seconds);

            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        void correctHours(int hours)
        {
            if (hours < 0 || hours > 23) throw new ApplicationException("Некоректно введено години!!!");
        }

        void correcrMinutes(int minutes)
        {
            if (minutes < 0 || minutes > 59) throw new ApplicationException("Некоректно введено хвилини!!!");
        }

        void correctSeconds(int seconds)
        {
            if (seconds < 0 || seconds > 59) throw new ApplicationException("Некоректно введені секунди!!!");
        }
        public int Hours
        {
            get { return hours; }
            set
            {
                correctHours(value);
                hours = value;
            }
        }

        public int Minutes
        {
            get { return minutes; }
            set
            {
                correcrMinutes (value);
                minutes = value;
            }
        }

        public int Seconds
        {
            get { return seconds; }
            set
            {
                correctSeconds (value);
                seconds = value;
            }
        }

        public static string title()
        {
            return "Час: ";
        }

        public void changeTimeSeconds(int seconds)
        {
            if (seconds > 0) 
            {
                this.seconds += seconds;
                this.minutes += this.seconds / 60;
                this.seconds %= 60;
                this.hours += this.minutes / 60;
                this.minutes %= 60;
                this.hours %= 24;
            }
            else
            {
                this.seconds = (this.hours * 3600) + (this.minutes * 60) + this.seconds + seconds;
                this.seconds = (this.seconds % 86400) % 86400 + 86400;
                this.hours = (this.seconds / 3600) % 24;
                this.minutes = (this.seconds / 60) % 60;
                this.seconds = this.seconds % 60;
            }
        }

        public void changeTimeMinuses(int minutes)
        {
            if(minutes >= 0)
            {
                this.minutes += minutes;
                this.hours += this.minutes / 60;
                this.minutes %= 60;
                this.hours %= 24;
            }
            else 
            {
                this.minutes = (this.hours * 60) + this.minutes + minutes;
                this.minutes = ((this.minutes % 1440) + 1440) % 1440;
                this.hours = (this.minutes / 60) % 24;
                this.minutes = this.minutes%60;
            }
        }

        public void changeTimeHours(int hours)
        {
            if(hours >= 0)
            {
                this.hours += hours;
                this.hours %= 24;
            }
            else
            {
                this.hours=((this.hours+hours)%24+24)% 24;
            }
        }

        public override string ToString()
        {
            return $"{this.hours:D2}:{this.minutes:D2}:{this.seconds:D2}";
        }

    }
}
