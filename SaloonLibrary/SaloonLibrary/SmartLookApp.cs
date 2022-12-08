using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaloonLibrary;

namespace SmartLookSaloonApplication
{
    public class SmartLookApp
    {
        Bill bill = new Bill();
        CustomerDetails customerDetails = new CustomerDetails();
        Address address = new Address();
        Booking Booking = new Booking();
        Category category;

        public void addcart(string name)
        {
            category = new Category();
            category.Categoryname = name;
            bill.Category.Add(category);
        }
        public string printbill(string cname,int age,string gender,string cnumber,string doorno,string street,string area,string city,string pincode,DateTime date,string time)
        {
            address.Doorno = doorno;
            address.Street = street;
            address.Areaname = area;
            address.City = city;
            address.Pincode = pincode;
            customerDetails.Customername = cname;
            customerDetails.Age = age;
            customerDetails.Gender = gender;
            customerDetails.Contactnumber = cnumber;
            customerDetails.Addressdetail = address;
            
            Booking.Date = date;
            Booking.Time = time;
            bill.CustomerDetails = customerDetails;
            bill.Bookingdetail = Booking;
            return bill.ToString();
        }
    }
}
