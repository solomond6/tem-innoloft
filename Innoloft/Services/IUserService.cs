using Innoloft.Models;

namespace Innoloft.Services
{
    public interface IUserService
    {
        public IEnumerable<User> GetUserList();
        public User GetUserById(int id);
        public User AddUser(User _user);
    }
}
