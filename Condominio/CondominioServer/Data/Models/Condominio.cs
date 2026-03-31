namespace CondominioServer.Data.Models;

public class Condominio : AuditModel
{
    public string Nome { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;
    // HasOne SindicoAtivo
    public virtual Sindico? SindicoAtivo { get; set; } = null!; // Síndico
    public virtual List<Sindico> Sindicos { get; set; } = []; // Lista histórica de Síndicos
    public List<Unidade> Unidades { get; set; } = []; // Unidades do condomínio
}
