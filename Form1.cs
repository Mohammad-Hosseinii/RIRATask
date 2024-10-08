using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Test.Product;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Product> products = new List<Product>
        {
           new Product { Id = 1, Name = "Product A", Category = Categories.Category1, Price = 100 },
           new Product { Id = 2, Name = "Product B", Category = Categories.Category1, Price = 150 },
           new Product { Id = 3, Name = "Product C", Category = Categories.Category2, Price = 120 },
           new Product { Id = 4, Name = "Product D", Category = Categories.Category3, Price = 200 },
           new Product { Id = 5, Name = "Product E", Category = Categories.Category1, Price = 80 }
        };

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            listBox1.DataSource = null;
            listBox1.DataSource = p.GetProducts(products);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            listBox1.DataSource = null;
            MessageBox.Show("Total prices is:" + " " + p.Total(products).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            listBox1.DataSource = null;
            MessageBox.Show("Maximum price is:" + " " + p.GetMaxPrice(products).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            listBox1.DataSource = null;
            listBox1.DataSource = p.Grouping(products);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            listBox1.DataSource = null;
            MessageBox.Show("Average prices is:" + " " + p.Average(products).ToString());
        }
    }
}
