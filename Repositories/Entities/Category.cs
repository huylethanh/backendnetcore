using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repositories.Entities
{
    public class Category : EntityBase
    {
        [Column("name", TypeName = "VARCHAR(50)")]
        public string Name { get; set; }

        [Column("description", TypeName = "TEXT)")]
        public string Description { get; set; }

        [Column("german_name", TypeName = "VARCHAR(50)")]
        public string GermanName { get; set; }

        [Column("is_deleted", TypeName = "TINYINT(1)")]
        public bool? IsDeleted { get; set; }
    }
}
