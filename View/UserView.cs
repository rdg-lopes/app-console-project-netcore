using System.Collections.Generic;
using AppConsole.Services;

namespace AppConsole.View;

public class UserView
{
    private IUserService service;

    public UserView(IUserService service)
    {
        this.service = service;
    }

    public async Task executarAsync(){
        IList<UserModel> listUsers = await this.service.getAllUsersAsync();
        foreach (UserModel user in listUsers){
            System.Console.WriteLine(user.Id + " - " + user.Nome);
        }
    }
}
