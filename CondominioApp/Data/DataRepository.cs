using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace CondominioApp.Data
{
    public class DataRepository
    {
        protected readonly SQLiteConnection db;

        public DataRepository()
        {
            var dbPath = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData), "condominium.db");
            db = new SQLiteConnection(dbPath);
            db.CreateTable<User>();
            /*
            db.CreateTable<Condominium>();
            db.CreateTable<Unit>();
            */
        }

    }
}
