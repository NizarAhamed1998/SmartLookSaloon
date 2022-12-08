using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaloonLibrary
{
    public class CustomerDetails
    {
        string customername;
        int age;
        string gender;
        Address addressdetail;
        string contactnumber;

        public string Customername 
        {
            get { return customername; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    customername = value;
                }
                else
                {
                    throw new ArgumentException("Please enter the correct data");
                }
            }
        }
        public int Age 
        {
            get { return age; }
            set
            {
                if (value>=6)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Please enter the correct data");
                }
            }
        }
        public string Contactnumber
        {
            get { return contactnumber; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    contactnumber = value;
                }
                else
                {
                    throw new ArgumentException("Please enter the correct data");
                }
            }
        }
        public Address Addressdetail 
        {
            get { return addressdetail; }
            set
            {
                addressdetail = value;
            }
        }

        public string Gender 
        {
            get { return gender; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Please enter the correct data");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Customername:{0}\nAge:{1}\nGender:{2}\nAddressdetail:{3}\nContactnumber:{4}", this.customername, this.age, this.gender, this.addressdetail.ToString(), this.contactnumber);
        }
    }
}
