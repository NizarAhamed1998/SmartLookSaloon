using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaloonLibrary;

namespace SmartLookSaloonApplication
{
    public partial class BillForm : Form
    {
        Files_and_directories fd = new Files_and_directories();
        SmartLookApp app = new SmartLookApp();
        List<Category> categories;
        BookedDetail bookedDetail;
        public BillForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Category item in categories)
            {
                if (item.Categoryname == comboBox2.Text)
                {
                    app.addcart(item.Categoryname, item.Categoryprice);
                    break;
                }

            }
            comboBox2.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(p);
            label1.Text = app.printbill(bookedDetail);
            app.remove();
           
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            categories = fd.getdata();
            foreach (Category item in categories)
            {
                comboBox2.Items.Add(item.Categoryname);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (BookedDetail item in BookedDetail.customerdetail)
            {
               
                    if (item.CustomerDetails.Customername==cname.Text&&item.CustomerDetails.Contactnumber==cnumber.Text)
                    {
                    bookedDetail = item;
                    }
               
            }
        }
    }
}
