using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Events.API.Models; // Add this line

namespace Events.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class EventController : ControllerBase
    {
        public IEnumerable<Event> _event = new Event[]{
            new Event(){
                    
                EventID = 1,
                Theme = "Angular 11 and .NET 5",
                Local = "Sao Paulo",
                Batch = "Batch 1",
                QttPeople = 250,
                DataEvent = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImageURL = "image-0.png"
                }
        };    

        
        [HttpGet("{id}")]

        public IEnumerable<Event> Get()
        {

            return _event;
                
        
        }

        [HttpGet]

        public string Post(){
            return "Post Exemple";
        }
    }
}
