using System.Collections.Generic;

namespace Matrix144WebApp.Entity
{
    public class User : BaseEntity
    {
        public User()
        {
            Roles = new List<Role>();
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Role> Roles { get; set; }
    }
}
