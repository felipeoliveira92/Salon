using Salon.Infra.Context;
using Salon.Model.Models;
using Salon.Service.DTOs;
using Salon.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Salon.Service.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SalonContext _context;

        public UserRepository()
        {
            _context = new SalonContext();
        }

        public void DeleteUser(int id)
        {
            if (id != 0)
            {
                var user = _context.Users.FirstOrDefault(u => u.IdUser == id);

                if (user != null)
                {
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                }
            }            
        }

        public User GetUserById(int id)
        {
            if (id != 0)
            {
                var user = _context.Users.FirstOrDefault(u => u.IdUser == id);

                if (user != null)
                {
                    return user;
                }
            }

            return null;
        }

        public User GetUserByLogin(string login)
        {
            if (!string.IsNullOrEmpty(login))
            {
                var user = _context.Users.FirstOrDefault(u => u.LoginUser == login);

                if (user != null)
                {
                    return user;
                }
            }

            return null;
        }

        public User GetUserByName(string name)
        {
            if(!string.IsNullOrEmpty(name))
            {
                var user = _context.Users.FirstOrDefault(u => u.NameUser == name);

                if (user != null)
                {
                    return user;
                }
            }

            return null;
        }

        public List<User> GetUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }

        public bool Login(string login, string password)
        {
            var user = GetUserByLogin(login);

            if(user != null)
            {
                if(user.PasswordUser == password)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        public bool Register(RegisterDTO model)
        {            
            try
            {
                var user = new User(model.NameUser, model.LoginUser, model.PasswordUser, model.Type);

                _context.Users.Add(user);
                _context.SaveChanges();

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }                       
        }

        public void SaveUser(User user)
        {
            if(user != null)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
        }

        public User UpdateUser(User user)
        {
            if(user.IdUser > 0)
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                return user;
            }

            return user;
        }
    }
}