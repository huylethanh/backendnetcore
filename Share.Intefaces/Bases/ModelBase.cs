using Newtonsoft.Json;
using Share.Intefaces.Entity;
using Share.Intefaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Share.Bases
{
    public class ModelBase<T> : IModelBase
        where T : IEntity
    {

        protected ModelBase(T entity)
        {
            this.Entity = entity;
            this.Initialize(entity);
        }

        public int Id { get => this.Entity.Id; set => this.Entity.Id = value; }

        [JsonIgnore]
        public T Entity
        {
            get;
        }

        public object GetEntity()
        {
            return this.Entity;
        }

        protected virtual void Initialize(T entity)
        {
        }
    }
}
