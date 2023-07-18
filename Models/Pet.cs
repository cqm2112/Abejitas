using System;
using System.Collections.Generic;

#nullable disable

namespace Abejitas.Models
{
    public partial class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int? OwnerId { get; set; }

        public virtual Owner Owner { get; set; }
    }
}
