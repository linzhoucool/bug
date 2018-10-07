using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models.Classes
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Project()
        {
            Users = new HashSet<ApplicationUser>();
        }
        public ICollection<ApplicationUser> Users { get; set;}
    }
}


