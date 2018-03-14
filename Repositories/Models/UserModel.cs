using Repositories.Entities;
using Share.Intefaces.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Share.Bases;

namespace Repositories.Models
{
    public class UserModel : ModelBase<User>, IUserModel
    {
        private IPositionModel position;

        public UserModel()
            : this(new User())
        {
        }

        public UserModel(User entity)
            : base(entity)
        {
           
        }

        protected override void Initialize(User entity)
        {
            if (entity.Position != null)
            {
                this.position = new PositionModel(entity.Position);
            }
        }

        public string FirstName
        {
            get
            {
                return this.Entity.FirstName;
            }
            set
            {
                this.Entity.FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.Entity.FirstName;
            }
            set
            {
                this.Entity.FirstName = value;
            }
        }

        public string FullName
        {
            get
            {
                return (this.FirstName + " " + this.LastName).Trim();
            }
        }

        public IPositionModel Position
        {
            get => this.position;
            set
            {
                this.position = value;
                this.Entity.Position = value.GetEntity() as Position;
            }
        }

        public string AccountName
        {
            get => this.Entity.AccountName;
            set => this.Entity.AccountName = value;
        }

        public string Password
        {
            get => this.Entity.Password;
            set => this.Entity.Password = value;
        }

        public string DisplayPosition
        {
            get => this.Entity.DisplayPosition;
            set => this.Entity.DisplayPosition = value;
        }

        public bool IsActivated
        {
            get => this.Entity.IsActivated;
            set => this.Entity.IsActivated = value;
        }

        public string Bio
        {
            get => this.Entity.Bio;
            set => this.Entity.Bio = value;
        }

        public bool? IsPublicPhone
        {
            get => this.Entity.IsPublicPhone;
            set => this.Entity.IsPublicPhone = value;
        }

        public bool? IsPublicEmail
        {
            get => this.Entity.IsPublicEmail;
            set => this.Entity.IsPublicEmail = value;
        }

        public string UserType
        {
            get => this.Entity.UserType;
            set => this.Entity.UserType = value;
        }

        public bool IsEnableNotification
        {
            get => this.Entity.IsEnableNotification;
            set => this.Entity.IsEnableNotification = value;
        }

        public string Avatar
        {
            get => this.Entity.Avatar;
            set => this.Entity.Avatar = value;
        }
    }
}
