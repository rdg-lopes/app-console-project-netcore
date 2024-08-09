using System.Collections.Generic;

namespace AppConsole.Persistence;

public interface IUserPersistence
{
    Task<IList<UserEntity>> getAllUserAsync();
}