using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ForgotPassword
    {
        [Required(ErrorMessage = "UserName is required")]
        public string Username { get; set; }      
    }

    public class UpdatePassword
    {
        public string password { get; set; }    
    }

}
