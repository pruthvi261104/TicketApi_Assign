using Microsoft.AspNetCore.Mvc;

namespace TicketApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController:ControllerBase
    {
        [HttpGet]
        public IActionResult GetTickets()
        {
            var tickets = new List<object>
              {
                new{
                    id=1,
                    sdesc="This is bus ticket",
                    desc="this is ticket to manali",
                    createdDate="2025-12-07",
                    severity="high",
                    targetDate="2025-12-09",
                    status="avaialble"},

                new{
                    id=2,
                    sdesc="This is train ticket",
                    desc="this is ticket to ladakh",
                    createdDate="2025-12-10",
                    severity="medium",
                    targetDate="2025-12-25",
                    status="unavaialble"
                
                }
               };
            return Ok(tickets);
        }
    }
}
