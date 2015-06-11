using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TicketSystem.Models
{
    public class Comment
    {
        public Comment()
        {

        }

        [Key]
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public virtual User Author { get; set; }

        public int TicketId { get; set; }

        public virtual Ticket Ticket { get; set; }


        [StringLength(1000, MinimumLength = 100)]
        public string Content { get; set; }
    }
}
