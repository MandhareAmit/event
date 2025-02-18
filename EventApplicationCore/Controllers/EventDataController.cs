﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventApplicationCore.Model;
using EventApplicationCore.Interface;


namespace EventApplicationCore.Controllers
{
    [Route("api/[controller]")]
    public class EventDataController : Controller
    {
        private IEvent _IEvent;
        public EventDataController(IEvent IEvent)
        {
            _IEvent = IEvent;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            try
            {
                return _IEvent.GetAllEvents();
            }
            catch (Exception)
            {
                throw;
            }
        }

       

    }
}
