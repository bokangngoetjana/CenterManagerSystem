using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CenterManagerSystem.Areas.Manager.Models
{
    public class UsersCategoryListModel
    {
        public int CategoryId { get; set; }
        public ICollection<UserModel> Users { get; set; }
        public ICollection<UserModel> UsersSelected { get; set; }
    }
}
