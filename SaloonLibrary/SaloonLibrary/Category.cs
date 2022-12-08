using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaloonLibrary
{
   public class Category
    {
        string categoryname;
        float categoryprice;

        public string Categoryname
        {
            get { return categoryname; }
            set { categoryname = value; }
        }
        public float Categoryprice 
        {
            get { return categoryprice; }
            set { categoryprice = value; }
        }
        public override string ToString()
        {
            return string.Format("CategoryName:{0}\nCategoryPrice:{1}", this.categoryname, this.categoryprice);

        }
    }
}
