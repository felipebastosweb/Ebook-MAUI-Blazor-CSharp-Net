namespace CondominioApp.Data.Repositories;

using CondominioApp.Data.Models;
using SQLite;


public class UserRepository
{
    public UserRepository() { }

    public async Task<Usuario?> CreateOrLoginAsync(Usuario user)
    {
        await BaseRepository<Usuario>.Init();
        var db = BaseRepository<Usuario>.db;

        var aux = await db.Table<Usuario>()
            .Where(x => x.Email == user.Email)
            .FirstOrDefaultAsync();

        if (aux == null)
        {
            user.UltimoAcesso = DateTime.UtcNow;
            await db.InsertAsync(user);
            return user;
        }
        else
        {
            aux.UltimoAcesso = DateTime.UtcNow;
            await db.UpdateAsync(aux);
            return aux;
        }
    }

    public async Task<Usuario?> GetUserAsync(int id)
    {
        await BaseRepository<Usuario>.Init();
        var db = BaseRepository<Usuario>.db;
        return await db.Table<Usuario>().Where(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task<Usuario?> FindUserByEmailAsync(string email)
    {
        await BaseRepository<Usuario>.Init();
        var db = BaseRepository<Usuario>.db;
        return await db.Table<Usuario>().Where(x => x.Email == email).FirstOrDefaultAsync();
    }

    public async Task<List<Usuario>> GetUsersAsync()
    {
        await BaseRepository<Usuario>.Init();
        var db = BaseRepository<Usuario>.db;
        return await db.Table<Usuario>().ToListAsync();
    }

    public async Task<int> DeleteUserAsync(Usuario user)
    {
        await BaseRepository<Usuario>.Init();
        var db = BaseRepository<Usuario>.db;
        return await db.DeleteAsync(user);
    }
}
