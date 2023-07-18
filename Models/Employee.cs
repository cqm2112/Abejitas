using System;
using System.Collections.Generic;

#nullable disable

namespace Abejitas.Models
{
    public partial class Employee
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Userpassword { get; set; }
        public string Rol { get; set; }
    }
}
