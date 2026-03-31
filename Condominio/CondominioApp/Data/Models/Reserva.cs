namespace CondominioApp.Data.Models;

using SQLite;


public class Reserva : BaseModel
{
    public int CondominioId { get; set; }
    public int SpaceId { get; set; }
    public int UnidadeId { get; set; }
    public string ResponsiblePerson { get; set; }
    public DateTime ReservationStartTime { get; set; }
    public DateTime ReservationStartTime { get; set; }
    public decimal TotalFeesAmount { get; set; }
    public bool IsFeePaid { get; set; }
    public DateTime DateCreation { get; set; }
}
