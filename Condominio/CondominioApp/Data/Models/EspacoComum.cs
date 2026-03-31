
using System.ComponentModel.DataAnnotations;

namespace CondominioApp.Data.Models;

public class EspacoTipo : BaseModel
{
    [MaxLength(100)]
    public string Nome { get; set; } = string.Empty;
    [MaxLength(500)]
    public string Description { get; set; } = string.Empty;
    public int Capacity { get; set; }
}

public class EspacoComum : BaseModel
{
    public int CondominioId { get; set; }
    public string EspacoTipoId { get; set; }
    [MaxLength(100)]
    public string Nome { get; set; } = string.Empty;
    [MaxLength(500)]
    public string Description { get; set; } = string.Empty;
    public int CapacidadePessoas { get; set; }
    public virtual List<EspacoComumItem> SpaceItemList { get; set; }
    public virtual List<Fee> FeeList { get; set; }
    public virtual List<Reserva> ListaDeReservas { get; set; }
}
