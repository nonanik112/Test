using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Json_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Jobs jobs7 = new Jobs()
            {
                Id = 7,
                FirstName = "Michael",
                LastName = "Lawson",
                Email = "michael.lawson@reqres.in",
                Avatar = new List<string>()
                {
                    "https://reqres.in/img/faces/7-image.jpg"
                }

            };

            Jobs jobs8 = new Jobs()
            {
                Id = 8,
                FirstName = "Lindsay",
                LastName = "Ferguson",
                Email = "lindsay.ferguson@reqres.in",
                Avatar = new List<string>()
                {
                    "https://reqres.in/img/faces/7-image.jpg"
                }
            };
            Jobs jobs9 = new Jobs()
            {
                Id = 9,
                FirstName = "Tobias",
                LastName = "Funke",
                Email = "tobias.funke@reqres.in",
                Avatar = new List<string>()
                {
                    "https://reqres.in/img/faces/9-image.jpg"
                }
            };
            Jobs jobs10 = new Jobs()
            {
                Id = 10,
                FirstName = "Byron",
                LastName = "Fields",
                Email = "byron.fields@reqres.in",
                Avatar = new List<string>()
                {
                    "https://reqres.in/img/faces/10-image.jpg"
                }
            };
            Jobs jobs11 = new Jobs()
            {
                Id = 11,
                FirstName = "George",
                LastName = "Edwards",
                Email = "george.edwards@reqres.in",
                Avatar = new List<string>()
                {
                    "https://reqres.in/img/faces/11-image.jpg"
                }
            };
             Jobs jobs12 = new Jobs()
            {
                Id = 11,
                FirstName = "Rachel",
                LastName = "Howell",
                Email = "rachel.howell@reqres.in",
                Avatar = new List<string>()
                {
                    "https://reqres.in/img/faces/12-image.jpg"
                }
            };
            string strResultJson = JsonConvert.SerializeObject(jobs7);
            string btrResultJson = JsonConvert.SerializeObject(jobs8);
            string ctrResultJson = JsonConvert.SerializeObject(jobs9);
            string ltrResultJson = JsonConvert.SerializeObject(jobs10);
            string gtrResultJson = JsonConvert.SerializeObject(jobs11);
            string dtrResultJson = JsonConvert.SerializeObject(jobs12);
           Console.WriteLine(strResultJson + "" + btrResultJson + "" + ctrResultJson + " " + ltrResultJson + "" +gtrResultJson + "" + dtrResultJson  );

            Console.ReadLine();
        }
        
    }
}
