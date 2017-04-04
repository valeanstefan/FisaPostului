using FisaPostului.Domain.Database;
using FisaPostului.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisaPostului.Domain.Repository
{
    public  interface IUserManager  : IBaseManager
    {
        UserDto GetById(int id);
        void Update(UserDto user);
        void Delete(int id);
        UserDto Insert(UserDto user);
        List<Users> GetAllUsers();
        List<UserDto> GetAllDtos();
        bool IsUserValid(string username, string password); 

    }
}
