using Share.Intefaces.Models;
using System.Collections.Generic;

namespace Share.Intefaces.Repositories
{
    public  interface IUserRepository
    {
        IEnumerable<IUserModel> GetUsers(string query);
    }
}
