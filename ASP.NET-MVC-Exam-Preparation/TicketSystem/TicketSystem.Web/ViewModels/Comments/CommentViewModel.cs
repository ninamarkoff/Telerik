using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketSystem.Models;
using TicketSystem.Web.Infrastructure.Mapping;

namespace TicketSystem.Web.ViewModels.Comments
{
    public class CommentViewModel : IMapFrom<Comment>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string AuthorName { get; set; }

        public string Content { get; set; }

        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<Comment, CommentViewModel>()
                .ForMember(c => c.AuthorName, opt => opt.MapFrom(c => c.Author.UserName));
        }
    }
}