using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Categories Category { get; set; }
        public int Price { get; set; }

        public enum Categories
        {
            Category1,
            Category2,
            Category3,
        }

        //I used lambda in task 2, 3 and 5 to do my job.
        //Task1
        //Get product by kind of category.
        public List<string> GetProducts(List<Product> productList)
        {
            var productName = from i in productList where i.Category == Categories.Category1 select i.Name;
            return productName.ToList();
        }

        //Task2
        public int GetMaxPrice(List<Product> productList)
        {
            var maxPrice = productList.Max(i => i.Price);
            return maxPrice;
        }

        //Task3
        public int Total(List<Product> productList)
        {
            var totalPrice = productList.Sum(i => i.Price);
            return totalPrice;
        }

        //Task4
        public List<string> Grouping(List<Product> productList)
        {
            var q = from i in productList
                    group i by i.Category;
            List<string> groupList = new List<string>();
            foreach (var group in q)
            {
                //MessageBox.Show($"Grade {group.Key}:");
                groupList.Add(group.Key.ToString());
                foreach (var product in group)
                {
                    //MessageBox.Show($" {product.Name}");
                    groupList.Add(product.Name.ToString());
                }
                groupList.Add("**********");
            }
            return groupList;
        }

        //Task5
        public double Average(List<Product> productList)
        {
            var avg = productList.Average(i => i.Price);
            return avg;
        }
    }
}
