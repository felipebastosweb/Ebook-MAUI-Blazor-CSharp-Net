namespace CondominioServer.Data.Models;


public class Unidade
{
    public string Nome { get; set; } = string.Empty;
    public string Proprietario { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Guid CondominioId { get; set; }
    public virtual Condominio Condominio { get; set; } = null!;
}