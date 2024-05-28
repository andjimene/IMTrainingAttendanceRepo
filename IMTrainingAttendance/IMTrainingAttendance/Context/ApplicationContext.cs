using IMTrainingAttendance.Models;
using Microsoft.EntityFrameworkCore;

namespace IMTrainingAttendance.Context;

public class ApplicationContext : DbContext
{
    public DbSet<Trainer> Trainers { get; set; }
    public DbSet<Training> Trainings { get; set; }
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=MAINDESKTOP\SQLEXPRESS;Database=TrainingAttendanceDb;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=true");
    }
}
