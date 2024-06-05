using IMTrainingAttendance.Context;
using IMTrainingAttendance.Models;
using Microsoft.EntityFrameworkCore;

namespace IMTrainingAttendance.Services.TrainerServices;

public class UpdateTrainer
{
    private ApplicationContext _context;

    private DbSet<Trainer> _entities;

    public UpdateTrainer(ApplicationContext context)
    {
        _context = context;
        _entities = context.Set<Trainer>();
    }

    public async Task Handler(int id, Trainer trainer)
    {
        var dbEntityEntry = _context.Entry(trainer);

        _context.Update<Trainer>(trainer);
        _context.SaveChanges();
    }
}
