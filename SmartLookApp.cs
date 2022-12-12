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
        BookedDetail bookedDetail;
        Bill bill = new Bill();
        CustomerDetails customerDetails;
        Address address;
        Booking Booking;
        Category category;

        public void addcart(string name,float price)
        {
            category = new Category();
            category.Categoryname = name;
            category.Categoryprice = price;
            bill.Category.Add(category);
        }
        public void AddCustomer(string cname,int age,string gender,string cnumber,string doorno,string street,string area,string city,string pincode,DateTime date,string time)
        {
            bookedDetail = new BookedDetail();
            customerDetails = new CustomerDetails();
            address = new Address();
            Booking = new Booking();
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
            bookedDetail.CustomerDetails = customerDetails;

            Booking.Date = date;
            Booking.Time = time;
            bookedDetail.Bookingdetail = Booking;
            BookedDetail.customerdetail.Add(bookedDetail);
            
        }
        public string printbill(BookedDetail bookedDetail)
        {
            bill.Bookeddetail = bookedDetail;
            return bill.ToString();
        }
        public void remove()
        {
            bill.Category.Clear();
        }
    }
}
