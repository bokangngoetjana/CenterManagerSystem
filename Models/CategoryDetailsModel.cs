using System;
using System.Collections.Generic;
using System.Linq;
using CenterManagerSystem.Entities;
using System.Threading.Tasks;

namespace CenterManagerSystem.Models
{
    public class CategoryDetailsModel
    {
      public IEnumerable<GroupedCategoryItemsByCategoryModel> GroupedCategoryItemsByCategoryModels { get; set; }
      public IEnumerable<Category> Categories { get; set; }


    }
}
