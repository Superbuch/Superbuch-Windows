using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Superbuch.Entities
{
    public partial class Category
    {

        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        public virtual ICollection<Booking> bookings { get; set; }

        public Category()
        {
            bookings = new List<Booking>();
        }

    }
}