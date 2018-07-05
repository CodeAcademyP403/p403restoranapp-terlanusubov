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
    public partial class Admin : Form
    {
        Entry form;
        public Admin(Entry _form)
        {
            form = _form;
            InitializeComponent();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            foreach (Registered item in form.ListOfRegistered)
            {
                if(item.role == Role.Moderator)
                    cmbx_moderator.Items.Add(item.role);              
            }
         
        }

        private void cmbx_moderator_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Registered item in form.ListOfRegistered)
            {
                if (item.role == Role.Ofisiant)
                    cmbx_ofisiant.Items.Add(item.Name);
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }

        private void cmbx_ofisiant_SelectedIndexChanged(object sender, EventArgs e)      
        {
            List<OrderedProduct> ordersOfOfsiant = new List<OrderedProduct>();
            foreach (OrderedProduct item in form.orders)
            {
                ordersOfOfsiant.Add(item);
            }
            data_order.DataSource = ordersOfOfsiant;
        }
    }
}
