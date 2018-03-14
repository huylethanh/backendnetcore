using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repositories.Entities
{
    public class PostAttachement : EntityBase
    {
        [Column("path", TypeName = "VARCHAR(255)")]
        public string Path { get; set; }

        [Column("post_id", TypeName = "INT(11)")]
        [ForeignKey("post_id")]
        public int PostId { get; set; }

        [Column("screenshots", TypeName = "TEXT")]
        public string Screenshots { get; set; }
    }
}
