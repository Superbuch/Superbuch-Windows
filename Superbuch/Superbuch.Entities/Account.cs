using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Superbuch.Entities
{
    public partial class Account
    {

        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        public virtual ICollection<Booking> bookings { get; set; }

        public Account()
        {
            bookings = new List<Booking>();
        }
        
    }
}