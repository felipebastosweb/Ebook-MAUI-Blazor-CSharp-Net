using SQLite;

namespace CondominioApp.Data.Models;


public class Unidade : AuditModel
{
    public string Nome { get; set; } = string.Empty;
    public string Proprietario { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    // BelongsTo Condominio
    public int CondominioId { get; set; }
    public virtual Condominio Condominio { get; set; } = null!;
}