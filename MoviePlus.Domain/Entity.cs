using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Domain
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedAt { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
