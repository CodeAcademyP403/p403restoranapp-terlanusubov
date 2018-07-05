using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran_Full_App
{
    public partial class Ofisiant : Form
    {
       
        Entry form;
        public string OfisiantName { get; set; }
        List<Product> products;
        public Ofisiant(Entry _form):this()
        {
            form = _form;
            
        }
        public Ofisiant()
        {
            InitializeComponent();
         products = new List<Product>()
        {
            new Product
            {
                Name = "Sac",
                Price = 6,
                Count = 100,
                category = Category.IstiYemekler
            },
            new Product
            {
                Name = "Mimoza Salatı",
                Price = 2,
                Count = 100,
                category = Category.Salatlar
            },
            new Product
            {
                Name = "Cola",
                Price = 1,
                Count = 100,
                category = Category.Ickiler
            },
            new Product
            {
                Name = "Ezo Gelin",
                Price = 3,
                Count = 100,
                category = Category.Suplar
            },
            new Product
            {
                Name = "Paxlava",
                Price = 2,
                Count = 100,
                category= Category.Desertler
            }
        };
            cmbx_category.DataSource = Enum.GetNames(typeof(Category));

        }
        private void Ofisiant_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            
            form.Show();
            this.Hide();
        }

        private void cmbx_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedCategory = cmbx_category.SelectedItem.ToString();
            Category category = (Category)Enum.Parse(typeof(Category), SelectedCategory);
            List<string> foodNames = new List<string>();
            foreach (Product item in products)
            {
                if(item.category == category)
                {
                    foodNames.Add(item.Name);
                }
            }
            cmbx_name.DataSource = foodNames;

            
        }

        private void cmbx_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedFood = cmbx_name.SelectedItem.ToString();
            foreach (Product item in products)
            {
                if(SelectedFood == item.Name)
                {
                    txbx_price.Text = item.Price.ToString();
                }
            }
        }
        double total = 0;
        private void btn_order_Click(object sender, EventArgs e)
        {
            OrderedProduct orderedProduct = new OrderedProduct()
            {
                OfisiantName = OfisiantName,
                Name = cmbx_name.SelectedItem.ToString(),
                Price = Convert.ToDouble(txbx_price.Text),
                Count = Convert.ToInt32(txbx_count.Text),
            };        
            form.orders.Add(orderedProduct);

            list_name.Items.Add(orderedProduct.Name);
            list_price.Items.Add(orderedProduct.Price * orderedProduct.Count);
            list_count.Items.Add(orderedProduct.Count);
            total = total + (orderedProduct.Price * orderedProduct.Count);
            total_price.Text = total.ToString();


        }
    }
}
