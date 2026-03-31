using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

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
    public Guid CondominioId { get; set; }
    public Condominio Condominio { get; set; } = null!;
    public Guid EspacoTipoId { get; set; }
    public EspacoTipo? EspacoTipo { get; set; }
    [MaxLength(100)]
    public string Nome { get; set; } = string.Empty;
    [MaxLength(500)]
    public string Description { get; set; } = string.Empty;
    public int CapacidadePessoas { get; set; }
    public virtual List<string> SpaceItemList { get; set; } = new List<string>();
    public virtual List<string> FeeList { get; set; } = new List<string>();
    public virtual List<Reserva> ListaDeReservas { get; set; } = new List<Reserva>();
}
