using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketSystem.Models;
using TicketSystem.Web.Infrastructure.Mapping;

using AutoMapper.QueryableExtensions;

namespace TicketSystem.Web.ViewModels.Tickets
{
    public class TicketDetailsViewModel :IMapFrom<Ticket>, IHaveCustomMappings
    {
       
        public int Id { get; set; }
       
        public PriorityType Priority { get; set; }
      
        public string Title { get; set; }

        public string AuthorName { get; set; }
       
        public string Description { get; set; }

        public string CategoryName { get; set; }        

        public int? ImageId { get; set; }

        public ICollection<CommentViewModel> Comments { get; set; }

        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<Ticket, TicketDetailsViewModel>()
                .ForMember(m => m.CategoryName, opt => opt.MapFrom(t => t.Category.Name))
                .ForMember(m => m.AuthorName, opt => opt.MapFrom(t => t.Author.UserName))
                .ReverseMap();
        }
    }
}