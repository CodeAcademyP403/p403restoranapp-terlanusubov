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
    public partial class Moderator : Form
    {
        Entry form;
        Registiration registiration;
        public Moderator(Entry _form)
        {           
            form = _form;
            registiration = new Registiration(form);
            InitializeComponent();
        }

        private void Moderator_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }

        private void Moderator_Load(object sender, EventArgs e)
        {
            foreach (Registered item in form.ListOfRegistered)
            {
                if(item.role == Role.Ofisiant)
                {
                    cmbx_ofisinats.Items.Add(item.Name);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }
        public Ofisiant ofisiant;
        private void cmbx_ofisinats_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedOfisiant = cmbx_ofisinats.SelectedItem.ToString();
            List<OrderedProduct> orderOfOifsiant = new List<OrderedProduct>();
           
            foreach (OrderedProduct item in form.orders)
            {
                if(SelectedOfisiant == item.OfisiantName)
                {
                    orderOfOifsiant.Add(item);
                    
                }
            }
            data_order.DataSource = orderOfOifsiant;


        }
    }
}
