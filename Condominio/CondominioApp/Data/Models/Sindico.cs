namespace CondominioApp.Data.Models;

using SQLite;
using System.ComponentModel.DataAnnotations.Schema;


// Síndico do Condomínio
public class Sindico : AuditModel
{
    public string Nome { get; set; }
    public string Endereco { get; set; }

    // Contact Data
    public string Email { get; set; }
    public string Telefone { get; set; }

    public string NumberID { get; set; } // RG
    public string Cpf { get; set; } // CPF
    // BelongsTo Condominio
    public int CondominioId { get; set; }
    public virtual Condominio Condominio { get; set; }

}