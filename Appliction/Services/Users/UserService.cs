using Appliction.DTOS;
using Appliction.IRepositories;
using Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliction.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepositories _userRepositories;
        public UserService(IUserRepositories userRepositories)
        {
            _userRepositories = userRepositories;
        }

        public UserModel GetByUsername(string username)
        {
            return _userRepositories.GetByUsername(username);
        }

        public List<UserModel> GetUsers()
        {
            return _userRepositories.GetUsers();
        }

        public UserModel Registration(UserDTO userDTO)
        {
            UserModel model = new UserModel()
            {
                FullName = userDTO.FullName,
                Password = userDTO.Password,
                Email = userDTO.Email,
                UserName = userDTO.UserName,
            };
            return _userRepositories.Registration(model);
        }
    }
}
