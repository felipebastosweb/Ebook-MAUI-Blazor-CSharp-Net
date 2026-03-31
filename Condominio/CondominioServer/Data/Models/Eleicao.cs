namespace CondominioServer.Data.Models;

public class Eleicao
{
    public Guid SindicoId { get; set; }
    public virtual Sindico Sindico { get; set; } = null!;
    public DateTime DataInicio { get; set; } = DateTime.UtcNow;
    public DateTime? DataFim { get; set; } = DateTime.UtcNow;
}