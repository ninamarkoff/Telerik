using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketSystem.Data;

using AutoMapper.QueryableExtensions;
using TicketSystem.Web.ViewModels.Tickets;

namespace TicketSystem.Web.Controllers
{
    public class TicketsController : BaseController
    {
       public TicketsController(ITicketSystemData data):
           base(data)
        {

        }

        public ActionResult Details(int id)
        {
            var ticket = this.Data
                .Tickets
                .All()
                .Where( t => t.Id == id)
                .Project()
                .To<TicketDetailsViewModel>()
                .FirstOrDefault();

            if (ticket == null)
            {
                throw new HttpException(404, "Ticket not found");
            }

            ticket.Comments = this.Data
                .Comments
                .All()
                .Where(t => t.TicketId == id)
                .Project()
                .To<CommentViewModel>()
                .ToList();

            return View(ticket);
        }

        public ActionResult Image(int id)
        {
            var image = this.Data.Images.GetById(id);

            if (image == null)
            {
                throw new HttpException(404, "Image not found");
            }

            return File(image.Content, "image/" + image.FileExtension);
        }
    }
}