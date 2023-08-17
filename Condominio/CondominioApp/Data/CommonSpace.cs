using SQLite;

namespace CondominioApp.Data
{

    public class CondominiumSpaceType : BaseModel
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public int Capacity { get; set; }
    }

    public class CondominiumSpace : BaseModel
    {
        [Indexed] public int CondominiumId { get; set; }
        [Indexed] public string SpaceTypeId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public int Capacity { get; set; }
        [Ignore] public virtual List<CondominiumSpaceItem> SpaceItemList { get; set; }
        [Ignore] public virtual List<CondominiumSpaceReservation> ReservationList { get; set; }
    }

}
