namespace CondominioApp.Data.Models;

using SQLite;


public class Usuario
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    [Unique, NotNull, MaxLength(250)]
    public string Email { get; set; } = string.Empty;
    //[NotNull, MaxLength(36)]
    public string SenhaHash { get; set; } = string.Empty;
    public DateTime UltimoAcesso { get; set; } = DateTime.UtcNow;
}
