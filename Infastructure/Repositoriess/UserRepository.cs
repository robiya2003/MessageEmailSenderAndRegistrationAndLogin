using Appliction.IRepositories;
using Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Repositoriess
{
    public class UserRepository : IUserRepositories
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public UserModel GetByUsername(string username)
        {
            return _context.Users.FirstOrDefault(x=>x.UserName==username);
        }

        public List<UserModel> GetUsers()
        {
            return _context.Users.ToList();
        }

        public UserModel Registration(UserModel userModel)
        {
            _context.Users.Add(userModel);
            _context.SaveChanges();
            return userModel;
        }
    }
}
