using System;
using System.ComponentModel.DataAnnotations;

namespace Matrix144WebApp.Entity
{
    public class Product :BaseEntity
    {

        [MaxLength(30,ErrorMessage = "Max length is 30 symbol")]
        public string Name { get; set; }

        public int Code { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateDate { get; set; }

        public string Description { get; set; }
    }
}
