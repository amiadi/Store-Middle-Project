using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Store_Project.Models;
using System.Web.Mvc;
using System.Web.Routing;

namespace Store_Project
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //using (var DefaultUser = new Store_DB())
            //{
            //    var count = DefaultUser.tbl_Accounts.Count(u => u.Account_UserName == "admin");

            //    if (count == 0)
            //    {
            //        var account = new tbl_Accounts()
            //        {
            //            Account_FirstName = "Administrator",
            //            Account_LastName = "System",
            //            Account_BirthDate = DateTime.Today.Date,
            //            Account_UserName = "admin",
            //            Account_Password = "Password",
            //            Account_ID = 100,
            //            Account_City = null,
            //            Account_EmailAddress = "Administrator@example.com",
            //            Account_Mobile = 0504330220,
            //            Account_Phone = 048932321,
            //            Account_CreatedDate = DateTime.Now.Date,
            //            Role_ID = 1,
            //            Account_Country = null
            //        };
            //        DefaultUser.tbl_Accounts.Add(account);
            //        DefaultUser.SaveChanges();
            //    }
            //}
        }
    }
}
