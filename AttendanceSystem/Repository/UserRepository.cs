using AttendanceSystem.Models;

namespace AttendanceSystem.Repository;

public class UserRepository : IUserRepository
{
    private readonly Context _context;

    public UserRepository(Context context)
    {
        _context = context;
    }

    public bool IsUsernameExisted(string username)
    {
        var x = _context.Users.FirstOrDefault(x => x.Username == username);
        if (x != null)
            return true;
        return false;
    }

    public bool ValidateLogin(string username, string password)
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

    public void AddUser(User user)
    {
        _context.Users.Add(user);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}