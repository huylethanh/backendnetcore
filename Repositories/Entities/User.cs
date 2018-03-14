using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Entities
{
    public class User : EntityBase
    {
        public User()
        {
            //this.Posts = new HashSet<Post>();
        }

        [Column("last_name", TypeName = "VARCHAR(50)")]
        public string FirstName { get; set; }

        [Column("first_name", TypeName = "VARCHAR(50)")]
        public string LastName { get; set; }

        [Column("account_name", TypeName = "VARCHAR(50)")]
        public string AccountName { get; set; }

        [Column("password", TypeName = "VARCHAR(50)")]
        public string Password { get; set; }

        [Column("display_position", TypeName = "VARCHAR(50)")]
        public string DisplayPosition { get; set; }

        [Column("is_activated", TypeName = "TINYINT(1)")]
        public bool IsActivated { get; set; }

        [Column("bio", TypeName = "VARCHAR(255)")]
        public string Bio { get; set; }

        [Column("is_public_phone", TypeName = "TINYINT(1)")]
        public bool? IsPublicPhone { get; set; }

        [Column("is_public_email", TypeName = "TINYINT(1)")]
        public bool? IsPublicEmail { get; set; }

        [Column("user_type", TypeName = "VARCHAR(20)")]
        public string UserType { get; set; }

        [Column("is_enable_noti", TypeName = "TINYINT(1)")]
        public bool IsEnableNotification { get; set; }

        [Column("avatar", TypeName = "TEXT")]
        public string Avatar { get; set; }

        [Column("position_id", TypeName = "INT(11)")]
        [ForeignKey("position_id")]
        public int? PositionId { get; set; }

        public Position Position { get; set; }

        //public virtual ICollection<Post> Posts { get; set; }
    }
}
