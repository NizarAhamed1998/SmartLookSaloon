using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaloonLibrary
{
    public class Bill
    {
        CustomerDetails customerDetails;
        Booking bookingdetail;
        List<Category> category = new List<Category>();
         string format;
        float total;

        public CustomerDetails CustomerDetails 
        {
            get { return customerDetails; }
            set { customerDetails = value; }
        }
        public Booking Bookingdetail 
        {
            get { return bookingdetail; }
            set { bookingdetail = value; }
        }
        public List<Category> Category 
        {
            get { return category; }
            set { category = value; }
        }

        public string Format { get {return format; }  }

        public override string ToString()
        {
            format += "CustomerDetail\n";
            format += this.customerDetails.ToString()+"\n";
            format += this.bookingdetail.ToString()+"\n";
            foreach (Category item in category)
            {
                format += item.ToString() + "\n";
                total += item.Categoryprice;
            }
            format += "Total:\t" + total;
            return format;
        }
    }
}
