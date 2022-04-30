using Microsoft.EntityFrameworkCore;

namespace AttendanceSystem.Models;

public class Context : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Class> Classes { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Attendance> Attendances { get; set; }
    public DbSet<ClassStudent> ClassStudent { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=DiemDanh;Trusted_Connection=True;");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClassStudent>()
            .HasOne(x => x.Class)
            .WithMany(x => x.ClassStudents)
            .HasForeignKey(x => x.ClassId);
        modelBuilder.Entity<ClassStudent>()
            .HasOne(x => x.Student)
            .WithMany(x => x.ClassStudents)
            .HasForeignKey(x => x.StudentId);
        base.OnModelCreating(modelBuilder);
    }
}