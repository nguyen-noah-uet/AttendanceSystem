using System.ComponentModel.DataAnnotations;

namespace AttendanceSystem.Models;

public class Attendance
{
    [Key] public int AttendanceNumber { get; set; }
    public int ClassId { get; set; }
    public Class Class { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public string Status { get; set; }
}