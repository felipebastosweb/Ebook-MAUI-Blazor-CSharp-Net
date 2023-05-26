using System.Threading.Tasks;

using SQLite;

namespace CondominioApp.Data
{
    public class BaseRepository<T>
    {
        public static SQLiteConnectionAsync db;

        public static async Task Init()
        {
            if (db is not null)
            {
                return db;
            }

            var dbPath = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData), "condominium.db");
            db = await new SQLiteConnectionAsync(dbPath);

            db.CreateTable<User>();
            db.CreateTable<Condominium>();
            db.CreateTable<CondominiumUnit>();
        }

        public static async Task<List<T>> ListAll()
        {
            
        }
    }
}
