using AttendanceSystem.Models;

namespace AttendanceSystem.Repository;

public interface IClassRepository
{
    IEnumerable<Class> GetClassesByUser(int userId);
    IEnumerable<Class> GetClassesByStudent(int studentId);
    void InsertClass(Class c);
    void UpdateClass(Class c);
    void SaveChanges();

}