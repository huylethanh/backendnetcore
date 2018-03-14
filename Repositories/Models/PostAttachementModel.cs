using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Share.Bases;
using Share.Interfaces.Models;

namespace Repositories.Models
{
    public class PostAttachementModel : ModelBase<PostAttachement>, IPostAttachementModel
    {
        public PostAttachementModel()
            : this(new PostAttachement())
        {
        }

        public PostAttachementModel(PostAttachement attachement)
            : base(attachement)
        {
        }

        public string Path { get => this.Entity.Path; set => this.Entity.Path = value; }

        public int PostId { get => this.Entity.PostId; set => this.Entity.PostId = value; }

        public string Screenshots { get => this.Entity.Screenshots; set => this.Entity.Screenshots = value; }
    }
}
