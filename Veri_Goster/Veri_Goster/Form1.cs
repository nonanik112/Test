using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Goster
{
    public partial class Form1 : Form
    {
        const string path = @"C:\Users\Metehan\Desktop\İŞ SINAVI\Veri_Goster";

        public Customer Customer { get; set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_load(object sender, EventArgs e)
        {
            var serializedStr = File.ReadAllText(path);
            Customer = JsonConvert.DeserializeObject<Customer>(serializedStr, new JsonSerializerSettings());

            if (Customer == null)
            {
                Customer = new Customer
                {
                    Id = 7,
                    FirtName = "Michael",
                    LastName = "Lawson",
                    Email = "michael.lawson@reqres.in",
                    Avatar = "https://reqres.in/img/faces/7-image.jpg"

                };
                 Customer = new Customer
                {
                    Id = 8,
                    FirtName = "Lindsay",
                    LastName = "Ferguson",
                    Email = "lindsay.ferguson@reqres.in",
                    Avatar = "https://reqres.in/img/faces/8-image.jpg"

                };
                 Customer = new Customer
                {
                    Id = 9,
                    FirtName = "Tobias",
                    LastName = "Funke",
                    Email = "tobias.funke@reqres.in",
                    Avatar = "https://reqres.in/img/faces/9-image.jpg"

                };
                 Customer = new Customer
                {
                    Id = 10,
                    FirtName = "Byron",
                    LastName = "Fields",
                    Email = "byron.fields@reqres.in",
                    Avatar = "https://reqres.in/img/faces/10-image.jpg"

                };
                 Customer = new Customer
                {
                    Id = 11,
                    FirtName = "George",
                    LastName = "Edwards",
                    Email = "george.edwards@reqres.in",
                    Avatar = "https://reqres.in/img/faces/11-image.jpg"

                };
                 Customer = new Customer
                {
                    Id = 12,
                    FirtName = "Rachel",
                    LastName = "Howell",
                    Email = "rachel.howell@reqres.in",
                    Avatar = "https://reqres.in/img/faces/12-image.jpg"

                };
                
            }
            propertyGrid1.SelectedObject = Customer;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer.Id = ((Customer)propertyGrid1.SelectedObject).Id;
             Customer.FirtName = ((Customer)propertyGrid1.SelectedObject).FirtName;
             Customer.LastName = ((Customer)propertyGrid1.SelectedObject).LastName;
             Customer.Email = ((Customer)propertyGrid1.SelectedObject).Email;
             Customer.Avatar = ((Customer)propertyGrid1.SelectedObject).Avatar;

            var deserializedStr = JsonConvert.SerializeObject(Customer, Formatting.Indented);

            File.WriteAllText(path, deserializedStr);
        }
    }
}
