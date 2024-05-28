using IMTrainingAttendance.Context;
using IMTrainingAttendance.Models;

namespace IMTrainingAttendance.Services.TrainerServices;

public class UpdateTrainer
{
    private ApplicationContext _context;

    public UpdateTrainer(ApplicationContext context)
    {
        _context = context;
    }

    public async Task Handler(int id, Trainer trainer)
    {
        _context.Update<Trainer>(trainer);
        _context.SaveChanges();
    }
}
