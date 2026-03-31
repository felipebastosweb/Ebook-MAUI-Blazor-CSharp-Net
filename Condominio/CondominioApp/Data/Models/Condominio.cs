
namespace CondominioApp.Data.Models;

using SQLite;

public class Condominio : AuditModel
{
    public string Nome { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;

    public virtual Sindico SindicoAtual { get; set; } // Síndico

    public virtual List<Sindico> trusteeHistoric { get; set; } // Lista histórica de Síndicos

    public List<Unidade> Unidades { get; set; } = []; // Unidades do condomínio
}
