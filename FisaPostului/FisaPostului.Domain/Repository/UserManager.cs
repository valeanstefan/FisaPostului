using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FisaPostului.Domain.Database;
using FisaPostului.Domain.Models;
using Omu.ValueInjecter;

namespace FisaPostului.Domain.Repository
{
    public class UserManager : IUserManager
    {
        private readonly IRepository<Users> _userRepository;

        public UserManager(IRepository<Users> userRepository)
        {
            this._userRepository = userRepository;
        }
        public void Delete(int id)
        {
            Users userModel = _userRepository.Find(id);
            _userRepository.Delete(userModel);
            _userRepository.SaveChanges();
        }

        public void Dispose()
        {
            _userRepository.Dispose();
        }

        public List<UserDto> GetAllDtos()
        {
            List<Users> userList = _userRepository.All().ToList();
            List<UserDto> userDtoList = userList.Select(user => Mapper.Map<UserDto>(user)).ToList();
            return userDtoList;
        }

        public List<Users> GetAllUsers()
        {
            List<Users> userList = _userRepository.All().ToList();
            return userList;
        }

        public UserDto GetById(int id)
        {
            Users user = _userRepository.Find(id);
            if (user != null)
                return Mapper.Map<UserDto>(user);
            else
                return null;
            
        }

        public UserDto Insert(UserDto user)
        {
            if (user == null)
                return new UserDto();
           _userRepository.Insert(Mapper.Map<Users>(user));
           _userRepository.SaveChanges();
            return user;
        }

        public bool IsUserValid(string username, string password)
        {
            var user = _userRepository.All().Where(u => u.username == username && u.user_password == password);
            if (user.Any())
                return true;
            else
                return false;
        }

        public void Update(UserDto user)
        {
            if (user != null)
            {
                _userRepository.Update(Mapper.Map<Users>(user));
                _userRepository.SaveChanges();
            }
        }
    }
}