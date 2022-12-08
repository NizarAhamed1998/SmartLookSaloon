using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaloonLibrary
{
    public class Booking
    {
       
        DateTime date;
        string time;

       
        public DateTime Date
        {
            get { return date; }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    date = value.Date;
                }
                else
                {
                    throw new ArgumentException("Please enter the correct data");
                }
            }
        }
        public string Time 
        {
            get { return time; }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    time = value;
                }
                else
                {
                    throw new ArgumentException("Please enter the correct data");
                }
            }
        }
        public override string ToString()
        {
            return string.Format("Date:{0}\nTime:{1}",  this.date.ToString(), this.time);
        }
    }
}
