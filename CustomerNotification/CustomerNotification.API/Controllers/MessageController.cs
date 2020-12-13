using CustomerNotification.Models;
using CustomerNotificaton.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CustomerNotification.API.Controllers
{
    [ApiController]
    public class MessageController : ControllerBase
    {
        private IMessagingService _messagingService;

        public MessageController(IMessagingService service)
        {
            _messagingService = service;
        }

        [Route("api/messaging")]
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult("Welcome to Message Notification Service!!");
        }

        [Route("api/messaging/{userId}/new")]
        [HttpGet]
        public async Task<IActionResult> GetNewUserRegisteredResponse([FromRoute] Guid userId)
        {
            if(!ModelState.IsValid || userId == null)
            {
                return BadRequest();
            }

            var response = await _messagingService.GetUserRegisteredResponse(userId);

            if(response == null)
            {
                return NotFound("User Id does not exist.");
            }

            return Ok(response);
        }

        [Route("api/messaging/{userId}/block")]
        [HttpGet]
        public async Task<IActionResult> GetUserBlockedResponse([FromRoute] Guid userId)
        {
            if (!ModelState.IsValid || userId == null)
            {
                return BadRequest();
            }

            var response = await _messagingService.GetUserBlockedResponse(userId);

            if (response == null)
            {
                return NotFound("User Id does not exist.");
            }

            return Ok(response);
        }

        [Route("api/messaging/{userId}/delete")]
        [HttpGet]
        public async Task<IActionResult> GetUserDeletedResponse([FromRoute] Guid userId)
        {
            if (!ModelState.IsValid || userId == null)
            {
                return BadRequest();
            }

            var response = await _messagingService.GetUserDeletedResponse(userId);

            if (response == null)
            {
                return NotFound("User Id does not exist.");
            }

            return Ok(response);
        }
    } 
}
