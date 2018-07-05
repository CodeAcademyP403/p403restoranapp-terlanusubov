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
    public partial class Entry : Form
    {
       
        public Registiration registeration;
        public List<OrderedProduct> orders = new List<OrderedProduct>();
        public List<Registered> ListOfRegistered = new List<Registered>()
        {
            new Registered
            {
                Name = "Terlan",
                Password = "123",
                Surname = "Usubov",
                role = Role.Ofisiant,
            },
            new Registered
            {
                Name = "Babash",
                Password = "123",
                Surname = "Babashov",
                role = Role.Moderator,
               
            },
               new Registered
            {
                Name = "Fexri",
                Password = "123",
                Surname = "Babashov",
                role = Role.Admin,
              
            }
        };
        public Entry()
        {
            
            registeration = new Registiration(this);
            InitializeComponent();
        }
     
        private void btn_register_entry_Click(object sender, EventArgs e)
        {
            registeration.Show();
            this.Hide();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            foreach (Registered item in ListOfRegistered) 
            {
                if(txbx_username.Text == item.Name && txbx_password.Text == item.Password)
                {
                    if(item.role == Role.Ofisiant)
                    {
                        Ofisiant ofisiant = new Ofisiant(this);
                        ofisiant.OfisiantName = txbx_username.Text;
                        ofisiant.Show();
                        this.Hide();
                    }
                    else if(item.role == Role.Moderator)
                    {
                        Moderator moderator = new Moderator(this);
                        moderator.Show();
                        this.Hide();
                       
                    }
                    else
                    {
                        Admin admin = new Admin(this);
                        admin.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void Entry_Load(object sender, EventArgs e)
        {
            
        }
    }
}
