using Model;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Impementations
{
    public class EventService : IEventService
    {
        public readonly IEventRepository _eventRepository;
        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public bool AddEvent(Event _event)
        {
            return _eventRepository.AddEvent(_event);
        }

        public bool DeleteEvent(int id)
        {
            return _eventRepository.Delete(id);
        }

        public string GetAllEvents(int page)
        {
            return _eventRepository.GetAllEvents(page);
        }

        public string GetEventByBrand(int id)
        {
            return _eventRepository.GetEventsByBrand(id);
        }

        public string GetEventById(int id)
        {
            return _eventRepository.GetEventById(id);
        }

        public string GetEventByShop(int id)
        {
            return _eventRepository.GetEventsByShop(id);
        }

        public bool UpdateEvent(Event _event)
        {
            return _eventRepository.Update(_event);
        }
    }
}
