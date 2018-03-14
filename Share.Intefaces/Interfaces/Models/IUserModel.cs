using System;
using System.Collections.Generic;
using System.Text;

namespace Share.Intefaces.Models
{
    public interface IUserModel : IModelBase
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string FullName { get; }

        string AccountName { get; set; }

        string Password { get; set; }

        string DisplayPosition { get; set; }

        bool IsActivated { get; set; }

        string Bio { get; set; }

        bool? IsPublicPhone { get; set; }

        bool? IsPublicEmail { get; set; }

        string UserType { get; set; }

        bool IsEnableNotification { get; set; }

        string Avatar { get; set; }
    }
}
