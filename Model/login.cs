using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class login
    {
        [Required(ErrorMessage="UserName is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int UserId { get; set; }
        public string accesscode { get; set; }
        public string isreset { get; set; }
    }

}
