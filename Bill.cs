using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaloonLibrary
{
    public class Bill
    {
        BookedDetail bookeddetail;
        List<Category> category = new List<Category>();
         string format;
        float total;

       
        public List<Category> Category 
        {
            get { return category; }
            set { category = value; }
        }

        public string Format { get {return format; }  }

        public BookedDetail Bookeddetail { get => bookeddetail; set => bookeddetail = value; }

        public override string ToString()
        {
            
            format += this.bookeddetail.ToString()+"\n";
            
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
