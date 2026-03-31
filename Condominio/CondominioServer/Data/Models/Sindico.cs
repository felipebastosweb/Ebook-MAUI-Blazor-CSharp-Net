namespace CondominioServer.Data.Models;

// Síndico do Condomínio
public class Sindico : AuditModel
{
    public string Nome { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;

    // Contact Data
    public string Email { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Cpf { get; set; } // CPF
    public Guid CondominioId { get; set; }
    public virtual Condominio Condominio { get; set; } = null!;

}