using Innoloft.Data;
using Innoloft.Models;
using Microsoft.EntityFrameworkCore;

namespace Innoloft.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _dbContext;

        public UserService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User AddUser(User _user)
        {
            var result = _dbContext.Users.Add(_user);
            _dbContext.SaveChanges();
            return result.Entity;
        }


        public User GetUserById(int id)
        {
            return _dbContext.Users.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<User> GetUserList()
        {
            return _dbContext.Users.ToList();
        }

    }
}
