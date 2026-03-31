using SQLite;

namespace CondominioApp.Data.Models;


public class Unidade : AuditModel
{
    public string Nome { get; set; } = string.Empty;
    public string Proprietario { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    // BelongsTo Condominio
    public int CodominioId { get; set; }
    public virtual Condominio Codominio { get; set; } = null!;
}