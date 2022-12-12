using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaloonLibrary
{
    public class BookedDetail
    {
       public  static List<BookedDetail> customerdetail = new List<BookedDetail>();
        CustomerDetails customerDetails;
        Booking bookingdetail;

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

        public override string ToString()
        {
            return string.Format("CustomerDetail:\n{0}\nBookingDetail\n{1}", this.customerDetails.ToString(), this.bookingdetail.ToString());
           
        }
    }
}
