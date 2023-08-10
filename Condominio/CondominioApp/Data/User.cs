using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace CondominioApp.Data
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique, NotNull, MaxLength(250)]
        public string Email { get; set; }
        //[NotNull, MaxLength(36)]
        public string Password { get; set; }
        public DateTime LastAccess { get; set; }
    }
}
