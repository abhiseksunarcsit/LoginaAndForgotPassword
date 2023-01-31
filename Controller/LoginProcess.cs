﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
namespace BLL
{
    public interface IUserService
    {
        bool ValidateUser(string username, string password);
    }
    public class UserService : IUserService
    {
        private readonly KtMPracticeContext Context;
        public UserService(KtMPracticeContext context)
        {
            Context = context;
        }
        public bool ValidateUser(string username, string password)
        {
            //return false;
           

           var check = Context.Logins;
           var data = Context.Logins.Where(e => e.Username == username && e.Password == password).FirstOrDefault();
           return data == null ? false : true; 
        }

    }
}
