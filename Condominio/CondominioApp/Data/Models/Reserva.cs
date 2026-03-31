namespace CondominioApp.Data.Models;

using SQLite;
using System;

public class Reserva : BaseModel
{
    public int CondominioId { get; set; }
    public int SpaceId { get; set; }
    public int UnidadeId { get; set; }
    public string ResponsiblePerson { get; set; } = string.Empty;
    public DateTime ReservationStartTime { get; set; }
    public DateTime ReservationEndTime { get; set; }
    public decimal TotalFeesAmount { get; set; }
    public bool IsFeePaid { get; set; }
    public DateTime DateCreation { get; set; }
}
