using AttendanceSystem.Models;

namespace AttendanceSystem.Repository;

public class ClassStudentRepository : IClass_StudentRepository
{
    private readonly Context _context;

    public ClassStudentRepository(Context context)
    {
        _context = context;
    }

    public bool AddStudentToClass(int classId, int studentId)
    {
        var x = _context.ClassStudent.SingleOrDefault(x => x.ClassId == classId && x.StudentId == studentId);
        if (x == null)
        {
            _context.ClassStudent.Add(new ClassStudent() { ClassId = classId, StudentId = studentId });
            return true;
        }

        return false;
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public void RemoveStudentFormClass(int classId, int studentId)
    {
        var recordInDb = _context.ClassStudent.SingleOrDefault(x => x.ClassId == classId && x.StudentId == studentId);
        if (recordInDb != null)
        {
            _context.ClassStudent.Remove(recordInDb);
        }
    }
}