using Application.Activities;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
       
        // private readonly DataContext _context; after adding MediatR
        private readonly IMediator _mediator;
        
        public ActivitiesController(IMediator mediator)
        {            
            _mediator = mediator;            
        }   

        [HttpGet] //api/activities 
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _mediator.Send(new List.Query());
        }
        
        [HttpGet("{id}")] //api/activities/guid
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return Ok();
        }

        // [HttpPost("{id}")] //api/activities/Edit/{id}
        // public async Task<ActionResult<Activity>> EditActivity(Guid id)
        // {
        //     return await _context.Activities.FindAsync(id);
        // }

    }
}