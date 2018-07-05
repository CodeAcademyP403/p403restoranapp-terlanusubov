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
    public partial class Registiration : Form
    {
        public Entry form;
              
        public Registiration(Entry _form)
        {
            form = _form;        
            InitializeComponent();
        }

        private void Registiration_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
        }
        int _id = 1;
        private void btn_register_Click(object sender, EventArgs e)
        {
            bool response = true;
            Registered registered = new Registered()
            {
                Name = txbx_name.Text,
                Surname = txbx_surname.Text,
                Id = _id++,
                Password = txbx_password.Text,
                role = Role.Ofisiant
            };
            foreach (Registered item in form.ListOfRegistered)
            {
                if(item.Name == txbx_name.Text)
                    response = false;   
            }

            if (response)
            {
                MessageBox.Show("You regestired Succesfulyy!!");
                form.ListOfRegistered.Add(registered);
            }
            else
            {
                MessageBox.Show("This account has already registered!!");
            }
        }

     
    }
}
