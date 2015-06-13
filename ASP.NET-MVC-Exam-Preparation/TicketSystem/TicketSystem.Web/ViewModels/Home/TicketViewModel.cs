using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketSystem.Models;
using TicketSystem.Web.Infrastructure.Mapping;

namespace TicketSystem.Web.ViewModels.Home
{
    public class TicketViewModel : IMapFrom<Ticket>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string TicketTitle { get; set; }

        public string CategoryName { get; set; }

        public string AuthorUserName { get; set; }

        public int NumberOfComments { get; set; }

        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<Ticket, TicketViewModel>()
                .ForMember(m => m.TicketTitle, opt => opt.MapFrom(t => t.Title))
                .ForMember(m => m.CategoryName, opt => opt.MapFrom(t => t.Category.Name))
                .ForMember(m => m.AuthorUserName, opt => opt.MapFrom(t => t.Author.UserName))
                .ForMember(m => m.NumberOfComments, opt => opt.MapFrom(t => t.Comments.Count()))
                .ReverseMap();
        }
    }
}