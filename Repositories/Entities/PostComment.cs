using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repositories.Entities
{
    public class PostComment:EntityBase
    {
        [Column("post_id", TypeName = "INT(11)")]
        [ForeignKey("post_id")]
        public int PostId { get; set; }

        public virtual Post Post { get; set; }

        [Column("user_id", TypeName = "INT(11)")]
        [ForeignKey("user_id")]
        public int UserId { get; set; }

        public virtual User User { get; set; }

        [Column("content", TypeName = "LONGTEXT")]
        public string Content { get; set; }
    }
}
