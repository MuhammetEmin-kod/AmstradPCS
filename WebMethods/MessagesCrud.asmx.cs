using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;

namespace WebMethods
{
    /// <summary>
    /// Summary description for MessagesCrud
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MessagesCrud : System.Web.Services.WebService
    {


        LoginConnectDataContext db = new LoginConnectDataContext();
        [WebMethod]
        public List<Part> MessageList()
        {

            List<Part> parts = new List<Part>();
            var listmessage = from asd in db.Messages where asd.Status == false select asd;
            foreach (var item in listmessage)
            {
                if (item.Status == false)//garantiyealalım
                {
                    parts.Add(new Part() {  ID=item.ID ,Username = item.UserName, CategoryID = item.CategoryID, UserMessage = item.UserMessage, Status = item.Status });
                }


            }
            return parts;



        }
        [WebMethod]
        public string ConfirmedMessages(int MessageID)
        {
            var updatedEntity = from Message in db.Messages where Message.ID == MessageID select Message;
            foreach (var item in updatedEntity)
            {
                item.Status = true;
            }
            return "Message Confirmed";
        }

        [WebMethod]
        public string AddedMessage(string username, int categoryID, string userMessage)
        {
            LoginConnectDataContext dba = new LoginConnectDataContext();
            Message m1 = new Message();
            m1.UserName = username;
            m1.CategoryID = categoryID;
            m1.UserMessage = userMessage;
            m1.Status = false;
            db.Messages.InsertOnSubmit(m1);
            db.SubmitChanges();
            return "Message pending";
        }
        [WebMethod]
        public string ConfirmedUser(string username)
        {
            var updatedentity = from msg in db.Messages where msg.UserName == username select msg;
            foreach (var item in updatedentity)
            {
                item.Status= true;
                db.SubmitChanges();
               
            }
            return "Message Congirmed";


        }

    }

    public class Part
    {
        public int ID{ get; set; }
        public string Username { get; set; }
        public int CategoryID { get; set; }
        public string UserMessage { get; set; }
        public bool Status { get; set; }
    }
}
