using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IEventRepository
    {
        bool AddEvent(Event _event);
        string GetEventsByShop(int id);
        string GetEventsByBrand(int id);
        string GetEventById(int id);
        string GetAllEvents(int page);
        bool Update(Event _event);
        bool Delete(int id);

    }
}
