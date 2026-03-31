namespace CondominioServer.Data.Models;

public class Reserva : AuditModel
{
    public Guid CondominioId { get; set; }
    public virtual Condominio Condominio { get; set; } = null!;
    public int EspacoId { get; set; }
    public virtual Espaco Espaco { get; set; } = null!;
    public int UnidadeId { get; set; }
    public virtual Unidade Unidade { get; set; } = null!;
    public string NomeDoResponsavel { get; set; } = string.Empty;
    public DateTime DataHoraInicio { get; set; }
    public DateTime DataHoraFim { get; set; }
    public decimal ValorTotal { get; set; }
    public bool Pago { get; set; }
}
