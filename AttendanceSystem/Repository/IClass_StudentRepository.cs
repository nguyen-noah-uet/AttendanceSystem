namespace AttendanceSystem.Repository;

public interface IClass_StudentRepository
{
    bool AddStudentToClass(int classId, int studentId);
    void SaveChanges();
    void RemoveStudentFormClass(int classId, int studentId);
}