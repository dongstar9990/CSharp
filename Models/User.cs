using System;
using System.Collections.Generic;

#nullable disable

namespace Bai12_Phieu1.Models
{
    public partial class User
    {
        public User()
        {
            Invoices = new HashSet<Invoice>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
