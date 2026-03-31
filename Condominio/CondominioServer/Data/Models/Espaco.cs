namespace CondominioServer.Data.Models;

public class EspacoTipo : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public int CapacidadeTotal { get; set; } = 0;
}

public class Espaco : BaseModel
{
    public Guid CondominioId { get; set; }
    public virtual Condominio Condominio { get; set; }
    public Guid EspacoTipoId { get; set; }
    public virtual EspacoTipo EspacoTipo { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public virtual List<EspacoItem> EspacoItemList { get; set; }
    public virtual List<Taxa> Taxas { get; set; }
    public virtual List<Reserva> Reservas { get; set; }
}

public class EspacoItem : AuditModel
{

}