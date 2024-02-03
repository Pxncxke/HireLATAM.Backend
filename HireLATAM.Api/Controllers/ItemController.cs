using HireLATAM.Application.Features.Commands.CreateItem;
using HireLATAM.Application.Features.Queries.GetItems;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HireLATAM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ISender _sender;

        public ItemController(ISender sender)
        {
            _sender = sender;
        }

        // GET: api/<ItemController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var items = await _sender.Send(new GetItemQuery());

            if (items.Count > 0)
            {
                return Ok(items);
            }

            return NotFound();
        }

        // GET api/<ItemController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ItemController>
        [HttpPost]
        public async Task<IActionResult> Post(CreateItemCommand itemCommand)
        {
            await _sender.Send(itemCommand);

            return Ok();
        }

        // PUT api/<ItemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ItemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
