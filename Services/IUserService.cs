using System.Collections.Generic;

namespace AppConsole.Services;

public interface IUserService
{
    Task<IList<UserModel>> getAllUsersAsync();
}