using AttendanceSystem.Models;

namespace AttendanceSystem.Repository;

public interface IUserRepository
{
    bool CheckUsernamePassword(string username, string password);
    User? GetUserByUsername(string username);
}