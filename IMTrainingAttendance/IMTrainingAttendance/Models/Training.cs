using System.ComponentModel.DataAnnotations.Schema;

namespace IMTrainingAttendance.Models;

public class Training
{
    public int Id { get; set; }
    public string Description { get; set; }
    public DateTime Fecha { get; set; }
    public TrainingType TipoCapacitacion { get; set; }

    [ForeignKey("Trainer")]
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; }

    public IList<Employee> Employees { get; set; }
}
