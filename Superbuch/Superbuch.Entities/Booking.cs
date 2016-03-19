using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superbuch.Entities
{
    public partial class Booking
    {

        public long id { get; set; }

        [Required]
        public long account_id { get; set; }
        
        [Required]
        public long category_id { get; set; }

        [Required]
        [StringLength(500)]
        public string description { get; set; }
        
        [Required]
        public DateTime bdate { get; set; }

        public decimal sum { get; set; }

        public virtual Account account { get; set; }

        public virtual Category category { get; set; }

    }
}