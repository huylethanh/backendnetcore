using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repositories.Entities
{
   public class PostGroup:EntityBase
    {
        [Column("post_id", TypeName = "INT(10)")]
        [ForeignKey("post_id")]
        public int PostId { get; set; }

        public Post Post { get; set; }

        [Column("group_id", TypeName = "INT(10)")]
        public int? GroupId { get; set; }
    }
}
