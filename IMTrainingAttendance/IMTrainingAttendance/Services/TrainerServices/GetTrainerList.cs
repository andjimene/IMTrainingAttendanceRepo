using IMTrainingAttendance.Context;
using IMTrainingAttendance.Models;
using Microsoft.EntityFrameworkCore;

namespace IMTrainingAttendance.Services.TrainerServices;

public class GetTrainerList
{
    private ApplicationContext _context;
    private DbSet<Trainer> _entities;

    public GetTrainerList(ApplicationContext context)
    {
        _context = context;
        _entities = context.Set<Trainer>();
    }

    
    public async Task<List<Trainer>> Handler()
    {
        var list = _entities.AsNoTracking().ToList();
        
        return list;
    }

}
