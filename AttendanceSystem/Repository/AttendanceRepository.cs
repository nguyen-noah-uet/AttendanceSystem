using AttendanceSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace AttendanceSystem.Repository;

public class AttendanceRepository : IAttendanceRepository
{
    private readonly Context _context;

    public AttendanceRepository(Context context)
    {
        _context = context;
    }

    public IEnumerable<Attendance> GetAttendancesByClassId(int classId)
    {
        return _context.Attendances
            .Include(a => a.Class)
            .Include(a => a.Student)
            .Where(a => a.ClassId == classId);
    }

    public IEnumerable<Attendance> GetAttendancesByClassIdAndDate(int classId, DateTime date)
    {
        return _context.Attendances
            .Include(a => a.Class)
            .Include(a => a.Student)
            .Where(a => a.ClassId == classId && a.Date == date);
    }

    public void AddAttendance(Attendance attendance)
    {
        _context.Attendances.Add(attendance);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}

public interface IAttendanceRepository
{
    IEnumerable<Attendance> GetAttendancesByClassId(int classId);
    IEnumerable<Attendance> GetAttendancesByClassIdAndDate(int classId, DateTime date);
    void AddAttendance(Attendance attendance);
    void SaveChanges();
}