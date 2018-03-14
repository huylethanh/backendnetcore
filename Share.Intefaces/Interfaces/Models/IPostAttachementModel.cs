using Share.Intefaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Share.Interfaces.Models
{
    public interface IPostAttachementModel : IModelBase
    {
        string Path { get; set; }

        int PostId { get; set; }

        string Screenshots { get; set; }
    }
}
