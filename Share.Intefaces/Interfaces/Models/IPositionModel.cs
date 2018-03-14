using System;
using System.Collections.Generic;
using System.Text;

namespace Share.Intefaces.Models
{
    public interface IPositionModel : IModelBase
    {
        string Label { get; set; }

        string Color { get; set; }

        bool? IsDefault { get; set; }

        bool? IsDeleted { get; set; }
    }
}
