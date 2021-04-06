using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Goster
{
    public class Customer
    {
        [Category("ID Setting"), Description("Row number")]
        public int Id { get; set; }

        [Category("ID Setting"), Description("Name of the customer")]
        public string FirtName { get; set; }

        [Category("ID Setting"), Description("Name of the last name")]
        public string LastName { get; set; }

        [Category("ID Setting"), Description("Most current e-mail of the customer")]
        public string Email { get; set; }

        [Category("ID Setting"), Description("Name of the customer")]
        public string Avatar { get; set; }
    }
}
