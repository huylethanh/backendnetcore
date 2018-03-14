using Repositories.Entities;
using Share.Intefaces.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Share.Bases;
using Share.Interfaces.Models;
using System.Linq;

namespace Repositories.Models
{
    public class PostModel : ModelBase<Post>, IPostModel
    {
        private IUserModel user;

        private ICategoryModel category;

        private IList<IPostAttachementModel> postAttachement;

        public PostModel()
            : this(new Post())
        {
        }

        public PostModel(Post entity)
            : base(entity)
        {
        }

        public string Content
        {
            get
            {

                return this.Entity.Content;
            }
            set
            {
                this.Entity.Content = value;
            }
        }

        public IUserModel User
        {
            get
            {
                return this.user;
            }
            set
            {
                this.user = value;
                this.Entity.User = value.GetEntity() as User;
            }
        }

        public ICategoryModel Category
        {
            get => this.category;
            set
            {
                this.category = value;
                this.Entity.Category = value.GetEntity() as Category;
            }
        }

        public DateTime Timestamp
        {
            get => this.Entity.Timestamp;
            set => this.Entity.Timestamp = value;
        }

        public int CommentCount
        {
            get => this.Entity.CommentCount;
            set => this.Entity.CommentCount = value;
        }

        public int ReactionCount
        {
            get => this.Entity.ReactionCount;
            set => this.Entity.ReactionCount = value;
        }

        public bool Published
        {
            get => this.Entity.Published;
            set => this.Entity.Published = value;
        }

        public bool IsDeleted
        {
            get => this.Entity.IsDeleted;
            set => this.Entity.IsDeleted = value;
        }

        public string Color
        {
            get => this.Entity.Color;
            set => this.Entity.Color = value;
        }

        public string TextColor
        {
            get => this.Entity.TextColor;
            set => this.Entity.TextColor = value;
        }

        public IList<IPostAttachementModel> PostAttachement
        {
            get
            {
                return this.postAttachement;
            }

            set
            {
            }
        }


        protected override void Initialize(Post entity)
        {
            if (entity.User != null)
            {
                this.user = new UserModel(entity.User);
            }

            if (entity.Category != null)
            {
                this.category = new CategoryModel(entity.Category);
            }

            if (this.Entity.PostAttachments.Count > 0)
            {
                this.postAttachement = new List<IPostAttachementModel>();
                foreach (var item in this.Entity.PostAttachments)
                {
                    postAttachement.Add(new PostAttachementModel(item));
                }
            }
        }
    }
}
