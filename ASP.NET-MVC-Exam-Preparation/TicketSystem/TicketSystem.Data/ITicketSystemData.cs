using System;
using System.Data.Entity;
using TicketSystem.Models;
namespace TicketSystem.Data
{
    public interface ITicketSystemData
    {
        IRepository<Category> Categories { get; }
        IRepository<Comment> Comments { get; }
        DbContext Context { get; }       
        IRepository<Image> Images { get; }      
        IRepository<Ticket> Tickets { get; }
        IRepository<User> Users { get; }
        int SaveChanges();
        void Dispose();
    }
}
