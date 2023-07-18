using System;
using System.Collections.Generic;

#nullable disable

namespace Abejitas.Models
{
    public partial class Owner
    {
        public Owner()
        {
            Pets = new HashSet<Pet>();
        }

        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}
