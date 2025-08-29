using System.Collections.Generic;

namespace Matrix144WebApp.Entity
{
    public class Role :  BaseEntity
    {
        public Role()
        {
            Users = new List<User>();
        }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
