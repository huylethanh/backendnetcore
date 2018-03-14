using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using Repositories.Extensions;
using Repositories.Models;
using Share.Intefaces.Models;
using Share.Intefaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class PostRepository : IPostRepository
    {
        private MysqlDbContext context;
        public PostRepository(MysqlDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<IPostModel> GetList(int userId)
        {
            IList<int> groups = new List<int>() { 1, 15, 16, 17, 46, 22 };

            var abc = this.context.Posts.Where(e => e.UserId == 110 || e.PostGroups.Any(g => g.GroupId == null || groups.Contains(g.GroupId.Value) && e.IsDeleted != true && e.Published == true))
            .Include(e => e.User).ThenInclude(e => e.Position)
            .Include(e => e.PostAttachments)
            .Include(e => e.PostComments)
            .Include(e => e.Category)
            .Select(e => new PostModel(e))
            .OrderByDescending(e => e.Id)
            .Take(10).ToList();

            return abc;
        }

        public IEnumerable<Post> GetPosts(int userId)
        {
            IList<int> groups = new List<int>() { 1, 15, 16, 17, 46, 22 };

            var abc = this.context.Posts.Where(e => e.UserId == 110 || e.PostGroups.Any(g => g.GroupId == null || groups.Contains(g.GroupId.Value) && e.IsDeleted != true && e.Published == true))
            .Include(e => e.User).ThenInclude(e=>e.Position)
            .Include(e => e.PostAttachments)
            .Include(e => e.PostComments)
            .Include(e=>e.Category)
            .OrderByDescending(e => e.Id)
            .Take(10).ToList();

            return abc;
        }

        public object GetABC()
        {
            var items = new List<object>();
            var results =this.context.Database.ExecuteSqlQuery(@"Select * from styles");

            while (results.DbDataReader.Read())
            {
                items.Add(new
                {
                    id = results.DbDataReader["id"],
                    token = results.DbDataReader["label"]
                });
            }


            return items;
        }
    }
}
