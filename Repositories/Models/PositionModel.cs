using Repositories.Entities;
using Share.Intefaces.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Share.Bases;

namespace Repositories.Models
{
    public class PositionModel : ModelBase<Position>, IPositionModel
    {
        public PositionModel()
            : this(new Position())
        {
        }

        public PositionModel(Position position)
            : base(position)
        {
        }

        public string Label
        {
            get { return this.Entity.Label; }
            set
            {
                this.Entity.Label = value;
            }
        }

        public string Color
        {
            get { return this.Entity.Color; }
            set => this.Entity.Color = value;
        }

        public bool? IsDefault
        {
            get => this.Entity.IsDefault;
            set => this.Entity.IsDefault = value;
        }

        public bool? IsDeleted
        {
            get => this.Entity.IsDeleted;
            set => this.Entity.IsDeleted = value;
        }
    }
}
