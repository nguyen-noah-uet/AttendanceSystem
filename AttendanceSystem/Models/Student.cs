using System.ComponentModel.DataAnnotations;

namespace AttendanceSystem.Models;

public class Student
{
    [Key]
    public int Id { get; set; }

    public string StudentName { get; set; }
    public string Sex { get; set; }

    public IEnumerable<Attendance> Attendances { get; set; }
    public IEnumerable<ClassStudent> ClassStudents { get; set; }
    public override string ToString()
    {
        return StudentName;
    }
}