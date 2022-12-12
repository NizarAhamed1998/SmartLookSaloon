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
    public partial class Form1 : Form
    {
        SmartLookApp app = new SmartLookApp();
        Files_and_directories fd = new Files_and_directories();
       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadcategory();
        }
        public void loadcategory()
        {
            fd.checktableisthere();
           
            List<string> timelist = fd.gettimedata();
           
            foreach (string item in timelist)
            {
                comboBox3.Items.Add(item);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             app.AddCustomer(cname.Text, Convert.ToInt32(cage.Text), comboBox1.Text, cnumber.Text, addr_doorno.Text, addr_street.Text, addr_area.Text, addr_city.Text, addr_pincode.Text, dateTimePicker1.Value, comboBox3.Text);
            MessageBox.Show("Booked Successfull");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BillForm form = new BillForm();
            form.Show();
        }
    }
}
