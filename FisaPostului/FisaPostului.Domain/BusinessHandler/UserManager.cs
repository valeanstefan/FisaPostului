using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FisaPostului.Domain.Database;
using FisaPostului.Domain.Models;
using Omu.ValueInjecter;
using FisaPostului.Domain.BusinessHandler.Contracts;
using FisaPostului.Domain.BusinessHandler;

namespace FisaPostului.Domain.Repository
{
    public class UserManager : Handler<UserDto, Users>, IUserManager
    {
        public bool IsUserValid(string username, string password)
        {
            var user = this._repository.All()
                .Where(u => u.username == username && u.user_password == password);
            if (user.Any())
                return true;
            else
                return false;
        }        
    }
}