namespace CondominioServer.Data.Models;

public abstract class BaseModel
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; }
    public BaseModel()
    {
        Id = Guid.CreateVersion7();
        Ativo = true;
    }
}

public interface IAutenticado
{
    string? UsuarioId { get; set; }
}

public interface IAuditado
{
    DateTime CreatedAt { get; set; }
    DateTime? UpdatedAt { get; set; }
    DateTime? ArquivedAt { get; set; }
}

public abstract class AuditModel : BaseModel, IAutenticado, IAuditado
{
    public string? UsuarioId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? ArquivedAt { get; set; }
}
