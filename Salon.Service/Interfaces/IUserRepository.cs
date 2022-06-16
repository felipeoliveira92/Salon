namespace Salon.Service.Interfaces
{
    public interface IUserRepository
    {
        void SaveUser(User user);
        void DeleteUser(int id);
        User UpdateUser(int id, User user);
        List<User> GetUsers();
        User GetUserById(int id);
        User GetUserByName(string name);
        User GetUserByLogin(string login);
    }
}