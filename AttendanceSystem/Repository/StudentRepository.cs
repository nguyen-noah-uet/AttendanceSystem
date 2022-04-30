using AttendanceSystem.Models;

namespace AttendanceSystem.Repository;

public class StudentRepository : IStudentRepository
{
    private readonly Context _context;

    public StudentRepository(Context context)
    {
        _context = context;
    }

    public IEnumerable<Student> GetStudentsByClassId(int classId)
    {
        return from s in _context.Students
               join cs in _context.ClassStudent on s.Id equals cs.StudentId
               where cs.ClassId == classId
               select s;
    }

    public Student GetStudentById(int studentId)
    {
        var student = _context.Students.SingleOrDefault(s => s.Id == studentId);
        return student;
    }

    public void AddStudent(Student student)
    {
        _context.Students.Add(student);
    }

    public void UpdateStudent(Student student)
    {
        var studentInDb = _context.Students.SingleOrDefault(s => s.Id == student.Id);
        if (studentInDb != null)
        {
            studentInDb.StudentName = student.StudentName;
        }
    }

    public void DeleteStudent(int studentId)
    {
        var s = _context.Students.SingleOrDefault(s => s.Id == studentId);
        if (s != null)
            _context.Students.Remove(s);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public IEnumerable<Student> GetAll()
    {
        return from s in _context.Students select s;
    }
}

public interface IStudentRepository
{
    IEnumerable<Student> GetAll();
    IEnumerable<Student> GetStudentsByClassId(int classId);
    Student GetStudentById(int studentId);
    void AddStudent(Student student);
    void UpdateStudent(Student student);
    void DeleteStudent(int studentId);
    void SaveChanges();
}