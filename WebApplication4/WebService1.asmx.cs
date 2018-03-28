using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication4
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<Country> GetCustomersNew()
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
}
