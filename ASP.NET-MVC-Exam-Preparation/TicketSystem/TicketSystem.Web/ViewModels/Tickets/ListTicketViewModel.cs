using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketSystem.Models;
using TicketSystem.Web.Infrastructure.Mapping;

namespace TicketSystem.Web.ViewModels.Tickets
{
    public class ListTicketViewModel : IMapFrom<Ticket>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string TicketTitle { get; set; }

        public string CategoryName { get; set; }

        public string AuthorUserName { get; set; }

        public string Priority { get; set; }


        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<Ticket, ListTicketViewModel>()
                .ForMember(m => m.TicketTitle, opt => opt.MapFrom(t => t.Title))
                .ForMember(m => m.CategoryName, opt => opt.MapFrom(t => t.Category.Name))
                .ForMember(m => m.AuthorUserName, opt => opt.MapFrom(t => t.Author.UserName))
                .ForMember(m => m.Priority, opt => opt.MapFrom(t => t.Priority.ToString()))
                .ReverseMap();
        }
    }
}