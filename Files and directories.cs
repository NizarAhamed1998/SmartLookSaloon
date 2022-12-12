using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SaloonLibrary
{
    public class Files_and_directories
    {
        string filepath = Directory.GetCurrentDirectory();
       
        
        public void upload_category_data(List<Category> categories)
        {
            string data = "";
            foreach (Category item in categories)
            {
                data += item.Categoryname + "," + item.Categoryprice+"\n";
            }
            File.WriteAllText(filepath + "\\categorylist.txt", data);
        }
        public List<Category> getdata()
        {
            List<Category> list = new List<Category>();
            string[] filedata = File.ReadAllLines(filepath + "\\categorylist.txt");
            foreach (string item in filedata)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    string[] data = item.Split(',');

                    Category category = new Category();
                    category.Categoryname = data[0];
                    category.Categoryprice = float.Parse(data[1]);
                    list.Add(category);
                }
                else
                {
                    throw new ArgumentException("your category list is empty plz fill the detail");
                }
               
              
            }
            return list;
        }
        public List<string> gettimedata()
        {
            List<string> timelist = new List<string>();
            string[] filedata = File.ReadAllLines(filepath + "\\timinglist.txt");
            if (filedata.Length!=0)
            {
                foreach (string item in filedata)
                {
                    timelist.Add(item);
                }
            }
            else
            {
                throw new ArgumentException("Please enter the timelist of your convinient work");
            }
            return timelist;
        }

        public void checktableisthere()
        {
            if (!File.Exists(filepath+ "\\categorylist.txt"))
            {
                File.Create(filepath + "\\categorylist.txt");
            }
            if (!File.Exists(filepath + "\\timinglist.txt"))
            {
                File.Create(filepath + "\\timinglist.txt");
            }
        }

        //public void updatefile(List)
        //{

        //}
    }
}
