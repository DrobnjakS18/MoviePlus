using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Domain
{
    public class UserUseCases : Entity
    {
        public int UserId { get; set; }

        public int UseCaseId { get; set; }

        public User Users { get; set; }
    }
}
