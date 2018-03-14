using System;
using System.Collections.Generic;
using System.Text;
using Share.Intefaces.Repositories;
using System.Linq;
using Share.Intefaces.Models;
using Repositories.Entities;
using Repositories.Models;

namespace Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private MysqlDbContext context;
        public UserRepository(MysqlDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<IUserModel> GetUsers(string query)
        {
            var list = this.context.Users.Select(e => new UserModel(e)).ToList();
            return list;           
        }
    }
}
