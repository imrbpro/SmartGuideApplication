using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services.Interfaces;

namespace SGA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {

        private readonly IEventService _eventService;
        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }
        [HttpGet]
        [Route("GetAll/{page}")]
        public string GetAllEvents(int page)
        {
            return _eventService.GetAllEvents(page);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public string GetEventById(int id)
        {
            return _eventService.GetEventById(id);
        }

        [HttpGet]
        [Route("GetByBrand/{id}")]
        public string GetEventByBrand(int id)
        {
            return _eventService.GetEventByBrand(id);
        }

        [HttpGet]
        [Route("GetByShop/{id}")]
        public string GetEventByShop(int id)
        {
            return _eventService.GetEventByShop(id);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public bool Delete(int id)
        {
            return _eventService.DeleteEvent(id);
        }
        [HttpPost]
        [Route("AddNew")]
        public bool AddEvent([FromBody] Event _event)
        {
            return _eventService.AddEvent(_event);
        }
        [HttpPut]
        [Route("Update")]
        public bool Update([FromBody] Event _event)
        {
            return _eventService.UpdateEvent(_event);
        }
    }
}
