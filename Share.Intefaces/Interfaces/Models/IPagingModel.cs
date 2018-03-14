using System;
using System.Collections.Generic;
using System.Text;

namespace Share.Interfaces.Models
{
    public interface IPagingModel
    {
        bool IsRefresh { get; set; }

        int LastestId { get; set; }
    }
}
