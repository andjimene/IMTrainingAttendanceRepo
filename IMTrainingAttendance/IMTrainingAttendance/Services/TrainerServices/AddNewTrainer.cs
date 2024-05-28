using IMTrainingAttendance.Context;
using IMTrainingAttendance.Models;

namespace IMTrainingAttendance.Services.TrainerServices;

public class AddNewTrainer
{
    private ApplicationContext _context;

    public AddNewTrainer(ApplicationContext context)
    {
        _context = context;
    }

    public async Task Handler(Trainer trainer)
    {
        _context.Trainers.Add(trainer);

        _context.SaveChanges();
    }
}
