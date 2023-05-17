using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1.Model
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<User> Users { get; private set; } = new ObservableCollection<User>();

    }
}
