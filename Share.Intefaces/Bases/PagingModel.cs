using Share.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Share.Bases
{
    public class PagingModel : IPagingModel
    {
        public bool IsRefresh { get; set; }

        public int LastestId { get; set; }
    }
}
