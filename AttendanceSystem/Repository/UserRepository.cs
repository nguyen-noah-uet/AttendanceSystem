using AttendanceSystem.Models;

namespace AttendanceSystem.Repository;

public class UserRepository : IUserRepository
{
    private readonly Context _context;

    public UserRepository(Context context)
    {
        _context = context;
    }

    public bool CheckUsernamePassword(string username, string password)
    {
        var user = _context.Users.SingleOrDefault(u => u.Username == username);
        if (user != null)
        {
            return user.Password == password;
        }

        return false;
    }

    public User? GetUserByUsername(string username)
    {
        return _context.Users.SingleOrDefault(u => u.Username == username);
    }
}