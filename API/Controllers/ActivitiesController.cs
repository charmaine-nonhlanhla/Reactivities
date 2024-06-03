using Microsoft.AspNetCore.Mvc;
using Domain;
using Application.Activities;
using Application;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    { 


        [HttpGet] //api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")] //api/activities/fdfkdffdfd
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        }


        [HttpPost]
        public async Task<IActionResult> CreateActivity([FromBody]Activity activity)
        {
            await Mediator.Send(new Create.Command { Activity = activity });
            return Ok();
        }
    }
}