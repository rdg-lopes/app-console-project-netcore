using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

namespace AppConsole.Persistence;

public class UserPersistence : DbContext, IUserPersistence
{
    public DbSet<UserEntity> users{get;set;}

    public UserPersistence(DbContextOptions options) : base(options)
    {}

    public async Task<IList<UserEntity>> getAllUserAsync(){
        IList<UserEntity> listUsers = await this.users.ToListAsync();
        return new List<UserEntity>(this.users.ToList());
    }
    
}