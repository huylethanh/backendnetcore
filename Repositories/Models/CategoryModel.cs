using Repositories.Entities;
using Share.Bases;
using Share.Intefaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Models
{
    public class CategoryModel : ModelBase<Category>, ICategoryModel
    {
        public CategoryModel()
            : this(new Category())
        {
        }

        public CategoryModel(Category category)
            : base(category)
        {
        }

        public string Name
        {
            get => this.Entity.Name;
            set => this.Entity.Name = value;
        }

        public string Description
        {
            get => this.Entity.Description;
            set => this.Entity.Description = value;
        }

        public string GermanName
        {
            get => this.Entity.GermanName;
            set => this.Entity.GermanName = value;
        }

        public bool? IsDeleted
        {
            get => this.Entity.IsDeleted;
            set => this.Entity.IsDeleted = value;
        }
    }
}
