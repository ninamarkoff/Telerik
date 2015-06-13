using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TicketSystem.Models;
using TicketSystem.Web.Infrastructure.Mapping;

namespace TicketSystem.Web.ViewModels.Comments
{
    public class PostCommentViewModel : IMapFrom<Comment>
    {
        public PostCommentViewModel()
        {

        }

        public PostCommentViewModel(int ticketId)
        {
            this.TicketId = ticketId;
        }
        public int TicketId { get; set; }


        [Required]
        [StringLength(1000, MinimumLength = 100)]
        [UIHint("MultiLineText")]
        public string Content { get; set; }       
    }
}