using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using CondominioApp.Data.Models;
using SQLite;

namespace CondominioApp.Data.Repositories
{
    public class BaseRepository<T> where T : class, new()
    {
        public static SQLiteAsyncConnection db;

        public static async Task Init()
        {
            if (db is not null)
            {
                return;
            }

            var dbPath = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData), "condominium.db");

            db = new SQLiteAsyncConnection(dbPath);

            await db.CreateTableAsync<Usuario>();
            await db.CreateTableAsync<Condominio>();
            await db.CreateTableAsync<Unidade>();
        }

        public static async Task<List<T>> ListAll()
        {
            await Init();
            return await db.Table<T>().ToListAsync();
        }
    }
}
