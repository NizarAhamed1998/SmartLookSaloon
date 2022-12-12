using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaloonLibrary
{
    public class Address
    {
        string doorno;
        string street;
        string areaname;
        string city;
        string pincode;

        public string Doorno 
        {
            get { return doorno; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    doorno = value;
                }
                else
                {
                    throw new ArgumentException("Please enter the correct data");
                }
            }
        }
        public string Street 
        {
            get { return street; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    street = value;
                }
                else
                {
                    throw new ArgumentException("Please enter the correct data");
                }
            }
        }
        public string Areaname 
        {
            get { return areaname; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    areaname = value;
                }
                else
                {
                    throw new ArgumentException("Please enter the correct data");
                }
            }
        }
        public string City 
        {
            get { return city; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    city = value;
                }
                else
                {
                    throw new ArgumentException("Please enter the correct data");
                }
            }
        }
        public string Pincode 
        {
            get { return pincode; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    pincode = value;
                }
                else
                {
                    throw new ArgumentException("Please enter the correct data");
                }
            }
        }
        public override string ToString()
        {
            return string.Format("DoorNo:{0}\tStreet:{1}\tAreaName:{2}\tCity:{3}\tPincode:{4}", this.doorno, this.street, this.areaname, this.city, this.pincode);
        }
    }
}
