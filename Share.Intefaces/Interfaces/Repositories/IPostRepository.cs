using Share.Intefaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Share.Intefaces.Repositories
{
    public interface IPostRepository
    {
        IEnumerable<IPostModel> GetList(int userId);

        object GetABC();
    }
}
