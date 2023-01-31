using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmailModel
    {
        //[Required]
        //public string To { get; set; }
        public string Subject { get; set; }

        public string SendEmail { get; set; }
        public string Body { get; set; }
        //public IFormFile Attachment { get; set; }

        [Required]
        public string Email = "abhiseksunar11@gmail.com";
        public string Password = "0310603Gabhisek";
       // public MailAddress Password { get; set; }

        //[Required]
        //public string password { get; set; }

    }
}
