using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Entities
{
    public class Post : EntityBase
    {
        public Post()
        {
            this.PostAttachments = new HashSet<PostAttachement>();
            this.PostGroups = new HashSet<PostGroup>();
            this.PostComments = new HashSet<PostComment>();
        }

        //[Column("content", TypeName = "LONGTEXT")]
        public string Content { get; set; }

        [Column("user_id", TypeName = "INT(11)")]
        [ForeignKey("user_id")]
        public int UserId { get; set; }

        public virtual User User { get; set; }

        [Column("category_id", TypeName = "INT(11)")]
        [ForeignKey("category_id")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public ICollection<PostAttachement> PostAttachments { get; set; }

        public ICollection<PostGroup> PostGroups { get; set; }

        public ICollection<PostComment> PostComments { get; set; }

        [Column("timestamp", TypeName = "DATETIME")]
        public DateTime Timestamp { get; set; }

        [Column("comment_count", TypeName = "INT(11)")]
        public int CommentCount { get; set; }

        [Column("reaction_count", TypeName = "INT(11)")]
        public int ReactionCount { get; set; }

        [Column("published", TypeName = "TINYINT(1)")]
        public bool Published { get; set; }

        [Column("is_deleted", TypeName = "TINYINT(1)")]
        public bool IsDeleted { get; set; }

        [Column("color", TypeName = "VARCHAR(10)")]
        public string Color { get; set; }

        [Column("text_color", TypeName = "VARCHAR(10)")]
        public string TextColor { get; set; }
    }
}
