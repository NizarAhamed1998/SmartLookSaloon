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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            app.addcart(comboBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           string p= app.printbill(cname.Text,Convert.ToInt32(cage.Text), comboBox1.Text,cnumber.Text, addr_doorno.Text, addr_street.Text, addr_area.Text, addr_city.Text, addr_pincode.Text, dateTimePicker1.Value, btime.Text);
            //listBox1.Items.Add(p);
            label16.Text = p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
