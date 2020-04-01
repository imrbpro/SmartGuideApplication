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
        bool Update(Event _event);

    }
}
