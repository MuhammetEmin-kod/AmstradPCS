using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebMethods
{
    /// <summary>
    /// Summary description for LoginCruds
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LoginCruds : System.Web.Services.WebService
    {

        LoginConnectDataContext db = new LoginConnectDataContext();

        [WebMethod]
        public int  Login(string UserName, string Password)
        {
            int Stats = 0;
            var Lgns = from User in db.Users select User;
            foreach (var item in Lgns)
            {
                if (item.UserName == UserName && item.Password == Password )
                {
                    if (item.AdminStatus==true)
                    {
                        Stats = 2;
                    }
                    else
                    {
                        Stats = 1;
                    }
                }
            }
            return Stats;
            //a=false;
            
        }

        [WebMethod]
        public string Register(string Name, string Surname, string Phone, string Username, string Password)
        {
            User usr = new User();
            usr.Name = Name;
            usr.Surname = Surname;
            usr.Phone = Phone;
            usr.UserName = Username;
            usr.Password = Password;
            usr.Status = false;
            usr.AdminStatus = false;
            db.Users.InsertOnSubmit(usr);
            db.SubmitChanges();
            return "Registration pending";
        }
        [WebMethod]
        public List<Usrs> UserShow()
        {
            List <Usrs> usrs = new List<Usrs>();
            var listUser= from usr in db.Users where usr.Status==false select usr;
            foreach (var item in listUser)
            {
                if (item.Status==false)
                {
                    usrs.Add(new Usrs() { Name = item.Name, Surname = item.Surname, UserName = item.UserName,Password=item.Password });
                }
            }
            return usrs;
        }

        [WebMethod]
        public string ConfirmedLogin(string username)
        {
            var uptadedEntity=from User in db.Users where User.UserName== username select User;
            foreach (var item in uptadedEntity)
            {
                item.Status = true;
                db.SubmitChanges();
            }
            return "Login Confirmed";
        }

    }
    public class Usrs
    {
       
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public bool AdminStatus { get; set; }

    }
}
