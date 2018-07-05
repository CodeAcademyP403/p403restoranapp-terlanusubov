using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_Full_App
{
   public class Registered
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public Role role { get; set; }
    }
}
