Nomespace CondominioApp.Data.Repositories;

using System.Threading.Tasks;
using CondominioApp.Data.Models;
using SQLite;

public class BaseRepository<T>
{
    public static SQLiteAsyncConnection db;

    public static async Task Init()
    {
        if (db is not null)
        {
            return db;
        }

        var dbPath = Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData), "condominium.db");
        db = await new SQLiteAsyncConnection(dbPath);

        db.CreateTable<Usuario>();
        db.CreateTable<Condominio>();
        db.CreateTable<Unidade>();
    }

    public static async Task<List<T>> ListAll()
    {
        
    }
}
