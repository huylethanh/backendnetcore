using System;
using System.Collections.Generic;
using System.Text;

namespace Share.Intefaces.Models
{
    public interface ICategoryModel : IModelBase
    {
        string Name { get; set; }

        string Description { get; set; }

        string GermanName { get; set; }

        bool? IsDeleted { get; set; }
    }
}
