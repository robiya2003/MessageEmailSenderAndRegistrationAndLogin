using Appliction.DTOS;
using Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliction.Services.Users
{
    public interface IUserService
    {
        public List<UserModel> GetUsers();
        public UserModel Registration(UserDTO userDTO);
        public UserModel GetByUsername(string username);
    }
}
