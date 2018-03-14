using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repositories.Entities
{
    public class Position : EntityBase
    {
        [Column("label", TypeName = "VARCHAR(45)")]
        public string Label { get; set; }

        [Column("color", TypeName = "VARCHAR(8)")]
        public string Color { get; set; }

        [Column("is_default", TypeName = "TINYINT(1)")]
        public bool? IsDefault { get; set; }

        [Column("is_deleted", TypeName = "TINYINT(1)")]
        public bool? IsDeleted { get; set; }
    }
}
