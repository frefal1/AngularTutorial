using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AngularTutorial.Models;


namespace AngularTutorial
{
    /// <summary>
    /// Summary description for swecompServices
    /// </summary>
    [WebService(Namespace = "http://angulartodo-3.apphb.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class swecompServices : System.Web.Services.WebService
    {
        
   
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World Hell yes!!";
        }

        [WebMethod]
        public object GetAllItems()
        {
            var helper = new Helpers.ListHelper();
            return helper.GetAllItems().ToList();
        }

        [WebMethod]
        public object GetLatest()
        {
            var helper = new Helpers.ListHelper();
            var items =  helper.GetLatestItems();
            return items;
        }
    }
}
