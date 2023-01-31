using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Context;


namespace BLL
{


    public interface IUserNameService
    {
        bool ResetPassword(string password, string username);
        bool ValidateUser(string username);
        bool AccessCode(string username);
        bool AccessCode2(string username, string resetCode);
       // bool AccessChecker(string username, string accesscode);
    }
    public class UserNameService : IUserNameService
    {
        private readonly KtMPracticeContext Context;

        public object TempData { get; private set; }

        public UserNameService(KtMPracticeContext context)
        {
            Context = context;
        }




        //for forgot password
        public bool ValidateUser(string username)
        {
            var check = Context.Logins;
            var data = Context.Logins.Where(e => e.Username == username).FirstOrDefault();
            return data == null ? false : true;

            //return false;

        }




        public bool ResetPassword(string username, string password)
        {
            var data = Context.Logins.Where(e => e.Username == username).FirstOrDefault();
            if (data != null)
            {
                //var user = Login.Identity.GetApplicationUser();

                data.Password = password;
                Context.Logins.Update(data);
                Context.Entry(data).State = EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool AccessCode(string username)
        {
            var data12 = Context.Logins.Where(x => x.Username == username).FirstOrDefault();
            data12.accesscode = null;
            // data12.isreset = "n";
            Context.Logins.Update(data12);
            Context.SaveChanges();
            return true;
        }

        public bool AccessCode2(string username,string resetCode)
        {
            var data = Context.Logins.Where(x => x.Username == username).FirstOrDefault();
            data.accesscode = resetCode;
            data.isreset = "y";
            Context.Logins.Update(data);
            Context.SaveChanges();
           // byte[] datetime = System.Text.Encoding.UTF8.GetBytes(DateTime.Now.ToString());
            return true;
        }

        //public bool AccessChecker(string username,string accesscode)
        //{
        //    var accesschecker = Context.Logins.Where(x => x.Username == username);
        //    if (accesschecker.FirstOrDefault().accesscode != accesscode)
        //    {
        //        //TempData["message"] = "Your token is expired";
        //        //return RedirectToAction("login", "login");
        //    }
        //    return true;
        //}
        
       
    }
}

