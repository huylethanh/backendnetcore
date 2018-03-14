using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class MysqlDbContext : DbContext
    {
        public MysqlDbContext(DbContextOptions<MysqlDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().ToTable("posts");
            //     .HasOne(x => x.User).WithMany(e => e.Posts).HasForeignKey(e => e.UserId);

            modelBuilder.Entity<PostAttachement>().ToTable("post_attachments");
            modelBuilder.Entity<PostGroup>().ToTable("post_groups");
            modelBuilder.Entity<PostComment>().ToTable("comments");

            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Position>().ToTable("positions");
            modelBuilder.Entity<Category>().ToTable("categories");
        }
    }
}
