using System;
using System.Collections.Generic;
using System.Text;

namespace Share.Intefaces.Models
{
    public interface IPostModel : IModelBase
    {
        string Content { get; set; }

        IUserModel User { get; set; }

        ICategoryModel Category { get; set; }

        DateTime Timestamp { get; set; }

        int CommentCount { get; set; }

        int ReactionCount { get; set; }

        bool Published { get; set; }

        bool IsDeleted { get; set; }

        string Color { get; set; }

        string TextColor { get; set; }
    }
}
