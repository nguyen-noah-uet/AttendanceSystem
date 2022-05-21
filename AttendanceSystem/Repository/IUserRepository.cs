using AttendanceSystem.Models;

namespace AttendanceSystem.Repository;

public interface IUserRepository
{
    bool IsUsernameExisted(string username);
    bool ValidateLogin(string username, string password);
    User? GetUserByUsername(string username);
    void AddUser(User user);
    void SaveChanges();
}