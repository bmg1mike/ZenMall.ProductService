using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDeleted { get; set; }
        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreatedDate = DateTime.Now;
            DateModified = DateTime.Now;
            IsDeleted = false;
        }

    }
}