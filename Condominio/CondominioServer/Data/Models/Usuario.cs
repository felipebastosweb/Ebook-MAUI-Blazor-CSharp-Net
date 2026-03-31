namespace CondominioServer.Data.Models;

public class Usuario : BaseModel, IAuditado
{
    public string Apelido { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string SenhaHash { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? ArquivedAt { get; set; }
}
