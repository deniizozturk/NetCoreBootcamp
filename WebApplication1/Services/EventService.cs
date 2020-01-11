using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IEventService
    {
        string Add(EventAddDTO model);
    }
    public class EventService : IEventService
    {
        private static IList<Event> data = new List<Event>();
        public string Add(EventAddDTO model)
        {
            Event entity = new Event
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow
            };
            entity.Name = model.Name;
            entity.StartDate = model.StartDate;
            entity.FinishDate = model.FinishDate;
            entity.Address = model.Address;
            entity.IsFree = model.IsFree;
            entity.Price = model.Price;
            entity.Subject = model.Subject;
            entity.Desc = model.Desc;

            data.Add(entity);

            return ("İşlem Başarılı");

        }
    }
    
}