
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using BLL;
using DAL.Context;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace StaffWeb.Controllers
{
    public class ForgotPasswordController : Controller
    {
        private IUserNameService UsernameService;
        public EmailModel emailmodel;

        private readonly KtMPracticeContext Context;

        public ForgotPasswordController(IUserNameService uService, KtMPracticeContext context)
        {
            UsernameService = uService;
            Context = context;
        }
        public IActionResult Index()
        {
            return View("~/Views/ForgotPassword/ForgotPassword.cshtml");
            //return View();   
        }




        public IActionResult Resetpassword(string username, string accesscode = null, string expiredate = null)
        {
            
            if (ModelState.IsValid)
            {
                bool valid;

                valid = UsernameService.ValidateUser(username);


                if (valid)
                {
                    // return RedirectToAction("ResetPassword", "ForgotPassword");
                    // write a code for generating a email link
                    if (!string.IsNullOrEmpty(accesscode))
                    {

                        byte[] data = Convert.FromBase64String(expiredate);
                        string exceedata = System.Text.ASCIIEncoding.ASCII.GetString(data);
                        if (Convert.ToDateTime(exceedata).AddMinutes(2) >= DateTime.Now)
                        {
                            // bool AccessChecker = UsernameService.AccessChecker(username, accesscode);
                            var accesschecker = Context.Logins.Where(x => x.Username == username);
                            if (accesschecker.FirstOrDefault().accesscode != accesscode)
                            {
                                TempData["message"] = "Your can not modify the url name";
                                return RedirectToAction("login", "login");

                            }

                            return View();
                        }
                        else
                        {
                            TempData["message"] = "Your token time is expired";
                            return RedirectToAction("login", "login", TempData["message"]);
                        }


                    }
                    else
                    {
                        string resetCode = Guid.NewGuid().ToString();
                        bool AccessCode2 = UsernameService.AccessCode2(username,resetCode );
                        
                        byte[] datetime = System.Text.Encoding.UTF8.GetBytes(DateTime.Now.ToString());


                        var verifyUrl = "/ForgotPassword/ResetPassword?accesscode=" + resetCode;
                        var link = "https://" + Request.Host.Value + verifyUrl + "&&username=" + username + "&&expiredate=" + System.Convert.ToBase64String(datetime);


                        var Subject = "Password Reset Request";
                        var body = "Hi " + username + ", <br/> You recently requested to reset your password for your account. Click the link below to reset it. " +

                             " <br/><br/><a href='" + link + "'>" + link + "</a> <br/><br/>" +
                             "If you did not request a password reset, please ignore this email or reply to let us know.<br/><br/> Thank you";



                        TempData["message"] = "Reset password link has been sent to your email id.";
                        SendEmail(body, Subject, username);
                        return RedirectToAction("login", "login", TempData["message"]);
                    }
                    // return View("~/Views/login/login.cshtml");
                    //return View("~/Views/ForgotPassword/ResetPassword.cshtml",username);

                }
                else
                {
                    //TempData["msg"] = "Please enter your correct username";
                    //return RedirectToAction("login", "login");
                    return View("~/Views/ForgotPassword/UpdatePassword.cshtml");


                }

            }
            //return View("~/Views/ForgotPassword/ForgotPassword.cshtml");
            return View("~/Views/login/login.cshtml");
        }



        public void SendEmail(string body, string subject, string username)
        {
            using (MailMessage mm = new MailMessage("abhiseksunar11@gmail.com", username))
            {
                mm.Subject = subject;
                mm.Body = body;
                mm.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient())
                {
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential("abhiseksunar11@gmail.com", "czwualygaiytzrow");
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mm);
                    // ViewBag.Message = "Email sent.";
                }
            }

        }



        public IActionResult UpdatePassword(string username, string password, string repassword)
        {
            if (ModelState.IsValid)
            {
                if (password == repassword)
                {

                    bool valid = UsernameService.ValidateUser(username);
                    if (valid)
                    {
                        bool isUpdate = UsernameService.ResetPassword(username, password);

                        bool AccessCode= UsernameService.AccessCode( username);

                       // //string checkdata=null;
                       // var data12 = _Context.Logins.Where(x => x.Username == username).FirstOrDefault();
                       // data12.accesscode = null;
                       //// data12.isreset = "n";
                       // _Context.Logins.Update(data12);
                       // _Context.SaveChanges();
                    }
                    else
                    {
                        return View();
                    }
                }
                else
                {
                    TempData["message"] = "Your Password and Confirm Password is not match!!!!";
                    return View("~/Views/ForgotPassword/UpdatePassword.cshtml", TempData["message"]);
                }
            }

            return View("~/Views/Home/Index.cshtml");


        }

        //public IActionResult PartialView(string username)
        //{
        //    return PartialView();
        //}


    }


}
