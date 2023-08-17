using SQLite;

namespace CondominioApp.Data
{
    public class Reservation : BaseModel
    {
        [Indexed] public int CondominiumId { get; set; }
        [Indexed] public int SpaceId { get; set; }
        [Indexed] public int UnitId { get; set; }
        public string ResponsiblePerson { get; set; }
        public DateTime ReservationStartTime { get; set; }
        public DateTime ReservationStartTime { get; set; }
        public decimal TotalFeesAmount { get; set; }
        public bool IsFeePaid { get; set; }
        public DateTime DateCreation { get; set; }
    }
}
