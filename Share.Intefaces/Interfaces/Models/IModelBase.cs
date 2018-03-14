using Newtonsoft.Json;
using Share.Intefaces.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Share.Intefaces.Models
{
    public interface IModelBase
    {
        int Id { get; set; }

        object GetEntity();
    }
}
