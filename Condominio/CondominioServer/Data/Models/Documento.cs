namespace CondominioServer.Data.Models;

public class Documento : AuditModel
{
    public Guid ReuniaoId { get; set; }
    public Reuniao Reuniao { get; set; } = null!;
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public DateTime DataCriacao { get; set; }
    public string UrlDocumento { get; set; } = string.Empty;
}