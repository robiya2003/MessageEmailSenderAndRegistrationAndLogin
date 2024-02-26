using Appliction.DTOS;
using Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliction.IRepositories
{
    public interface IUserRepositories
    {
        public List<UserModel> GetUsers();
        public UserModel Registration(UserModel userModel);
        public UserModel GetByUsername(string username);
    }
}
