namespace CondominioApp.Data.Models;

using SQLite;
using System.Collections.Generic;

public class Condominio : AuditModel
{
    public string Nome { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;

    public virtual Sindico? SindicoAtual { get; set; } // Síndico

    public virtual List<Sindico> Sindicos { get; set; } = new List<Sindico>(); // Lista histórica de Síndicos

    public List<Unidade> Unidades { get; set; } = new List<Unidade>(); // Unidades do condomínio
}
