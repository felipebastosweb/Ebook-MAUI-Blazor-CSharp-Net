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
    //public virtual List<Taxa> Taxas { get; set;
    //TODO: criar uma classe para Espaco com Preço onde serão cobrados as taxas de reserva, limpeza, etc. e a classe EspacoItem para os itens que compõem o espaço (ex: cadeiras, mesas, etc.)
    public virtual List<Reserva> Reservas { get; set; }
}

public class EspacoItem : AuditModel
{

}