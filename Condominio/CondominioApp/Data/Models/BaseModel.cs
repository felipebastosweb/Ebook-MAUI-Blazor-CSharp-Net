namespace CondominioApp.Data.Models;

using SQLite;

public abstract class BaseModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
}

public abstract class AuditModel : BaseModel
{
    public string? UsuarioId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? ArquivedAt { get; set; }
}
