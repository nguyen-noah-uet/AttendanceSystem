using System.ComponentModel.DataAnnotations;

namespace AttendanceSystem.Models;

public class Class
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string ClassName { get; set; }

    public int? NoOfSessions { get; set; }
    public User User { get; set; }

    public IEnumerable<Attendance> Attendances { get; set; }
    //public IEnumerable<Student> Students { get; set; }
    public IEnumerable<ClassStudent> ClassStudents { get; set; }
    public override string ToString() => ClassName;
}