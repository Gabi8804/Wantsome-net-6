using StoreApp.DataAccess;
using StoreApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace StoreApp.BusinessLogic.BusinessEntities
{
    public class UserHandler
    {
        private readonly UserRepository<Users> userRepo;
        private readonly GenericRepository<Users> genericUserRepo;
        private readonly GenericRepository<Roles> genericRoleRepo;
        public UserHandler()
        {
            userRepo = new UserRepository<Users>();
            genericUserRepo = new GenericRepository<Users>();
            genericRoleRepo = new GenericRepository<Roles>();
        }

        public bool IsUserValid(string userName, string password)
        {
            var result = userRepo.GetByUserName(userName);
            if (result != null)
            {
            return Crypto.VerifyHashedPassword(result.Password, password) ? true : false;
            }
            else
                return false;
        }

      public int GetUserIdByName(string username)
        {
            return userRepo.GetByUserName(username).UserId;
        }
        public void Create(UserModel registerUser)
        {
            var password = Crypto.HashPassword(registerUser.Password);
            
            var newUser = new Users
            {
                FirstName = registerUser.FirstName,
                LastName = registerUser.LastName,
                Password = password,
                RoleId = 2,
                UserName = registerUser.UserName
            };
            genericUserRepo.Create(newUser);
        }

        public string GetRoles(string username)
        {
            var roleId = genericUserRepo.ReadAll().Where(u=>u.UserName==username).Select(r=>r.RoleId).FirstOrDefault();
            return genericRoleRepo.ReadById(roleId).Name;
        }
    }
}
