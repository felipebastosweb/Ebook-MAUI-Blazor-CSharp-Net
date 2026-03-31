namespace CondominioServer.Data.Models;

/***
* Tipo de reunião (Reunião, Assembléia Ordinária, Assembléia Extraordinária)
***/
public class ReuniaoTipo : BaseModel
{
    public string Nome { get; set; } = string.Empty;
    public virtual List<Reuniao> Reunioes { get; set; } = [];
}

public class Reuniao
{
    public Guid ReuniaoTipoId { get; set; }
    public virtual ReuniaoTipo ReuniaoTipo { get; set; } = null!;
    public Guid CondominioId { get; set; }
    public virtual Condominio Condominio { get; set; } = null!;
    public string Titulo { get; set; } = string.Empty;
    public string Pauta { get; set; } = string.Empty;
    public string Ata { get; set; } = string.Empty;
    public DateTime DataInicio { get; set; } = DateTime.UtcNow;
    public DateTime? DataFim { get; set; }
}