using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Context
{
    public partial class Login
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string accesscode { get; set; }
        public string isreset { get; set; }
    }
}
