using AttendanceSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace AttendanceSystem.Repository
{
    public class ClassRepository : IClassRepository
    {
        private readonly Context _context;

        public ClassRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<Class> GetClassesByUser(int userId)
        {
            var users = _context.Users.Include(u => u.Classes).FirstOrDefault(u => u.Id == userId);
            return users.Classes;
        }

        public IEnumerable<Class> GetClassesByStudent(int studentId)
        {
            return from student in _context.Students
                   join attendance in _context.Attendances on student.Id equals attendance.StudentId
                   join c in _context.Classes on attendance.ClassId equals c.Id
                   where student.Id == studentId
                   select c;
        }

        public void InsertClass(Class c)
        {
            _context.Classes.Add(c);
        }

        public void UpdateClass(Class c)
        {
            var classInDb = _context.Classes.FirstOrDefault(cl => cl.Id == c.Id);
            if (classInDb != null)
            {
                classInDb.ClassName = c.ClassName;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
