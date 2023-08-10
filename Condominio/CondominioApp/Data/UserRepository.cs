using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace CondominioApp.Data
{

    public class UserRepository : DataRepository
    {
        public UserRepository() : base() { }

        public User CreateOrLogin(User user)
        {
            var rows = 0;
            var aux = db.Table<User>()
                .Where(x => x.Email == user.Email)
                .Where(x => x.Password == user.Password)
                .FirstOrDefault();
            if (aux == null)
            {
                user.LastAccess = DateTime.Now;
                rows = db.Insert(user);
            }
            else 
            aux.LastAccess = DateTime.Now;
            rows = db.Update(aux);
            return db.Table<User>()
                .Where(x => x.Email == user.Email)
                .FirstOrDefault();
        }
        public User GetUser(int i)
        {
            return db.Table<User>().FirstOrDefault(x => x.Id == i);
        }

        public User FindUserByEmail(string Email)
        {
            var user = db.Table<User>().Where(x => x.Email == Email).FirstOrDefault();
            return user;
        }

        public List<User> GetUsers()
        {
            return db.Table<User>().ToList();
        }

        public int DeleteUser(User user)
        {
            return db.Delete(user);
        }
    }
}
