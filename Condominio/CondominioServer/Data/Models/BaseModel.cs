namespace CondominioServer.Data.Models;

public abstract class BaseModel
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; }
}

public abstract class AuditModel : BaseModel
{
    public string? UsuarioId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? ArquivedAt { get; set; }
}
