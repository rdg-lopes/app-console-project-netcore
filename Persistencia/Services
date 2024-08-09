using System.Collections.Generic;
using AppConsole.Persistence;

namespace AppConsole.Services;

public class UserService : IUserService
{
    private IUserPersistence persistence;

    public UserService(IUserPersistence persistence)
    {
        this.persistence = persistence;
    }

    public async Task<IList<UserModel>> getAllUsersAsync()
    {
        IList<UserEntity> listUsers = await this.persistence.getAllUserAsync();
        IList<UserModel> listResult = listUsers.Select(user => new UserModel{
            Id = user.Id,
            Nome = user.Nome
        }).ToList();
        return listResult;
    }
}