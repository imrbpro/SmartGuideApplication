using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IEventService
    {
        string GetAllEvents(int page);
        string GetEventById(int id);
        string GetEventByBrand(int id);
        string GetEventByShop(int id);
        bool AddEvent(Event _event);
        bool DeleteEvent(int id);
        bool UpdateEvent(Event _event);
    }
}
