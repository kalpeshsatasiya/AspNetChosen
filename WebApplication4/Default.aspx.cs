using System;
using System.Collections.Generic;
using System.Web.UI;

namespace WebApplication4
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Web.Services.WebMethod]
        public static List<Country> GetCustomersNew()
        {
            List<Country> lstCountrys = new List<Country>()
            {
                new Country() { CountryID=1,CountryName = "India" },
                new Country() { CountryID=2,CountryName = "Australia" },
                new Country() { CountryID=3,CountryName = "UK" },
            };

            return lstCountrys;
        }
    }

    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
    }
}