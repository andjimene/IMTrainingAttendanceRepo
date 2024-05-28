using IMTrainingAttendance.Context;
using IMTrainingAttendance.Models;

namespace IMTrainingAttendance.Services.TrainerServices;

public class GetTrainerList
{
    private ApplicationContext _context;

    public GetTrainerList(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<List<Trainer>> Handler()
    {
        var list = _context.Trainers.ToList();

        return list;
    }
}
