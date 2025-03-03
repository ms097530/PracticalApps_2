using Microsoft.AspNetCore.Mvc;
using Packt.Shared;
using NorthwindService.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace NorthwindService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ICustomerRepository repo;
        // constructor injects repository registered in Startup
        public CustomersController(ICustomerRepository repo)
        {
            this.repo = repo;
        }
        // GET: api/customers
        // GET: api/customers/?country=[country]
        // this will always return a list of customers even if it's empty
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Customer>))]
        public async Task<IEnumerable<Customer>> GetCustomers(string country/*, string contactName*/)       // contactName was for testing passing multiple parameters to url
        {
            if (string.IsNullOrWhiteSpace(country)/* && string.IsNullOrWhiteSpace(contactName)*/)
            {
                return await repo.RetrieveAllAsync();
            }
            else
            {
                return (await repo.RetrieveAllAsync())
                    .Where(customer => (customer.Country == country)/* || (customer.ContactName == contactName)*/);
            }
        }
        // GET: api/customers/[id]
        [HttpGet("{id}", Name = nameof(GetCustomer))] // named route
        [ProducesResponseType(200, Type = typeof(Customer))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetCustomer(string id)
        {
            Customer c = await repo.RetrieveAsync(id);
            if (c == null)
            {
                return NotFound();  // 404 Resource not found
            }
            return Ok(c);   // 200 OK with customer in body
        }
        // POST: api/customers
        // BODY: Customer (JSON, XML)
        [HttpPost]
        [ProducesResponseType(201, Type = typeof(Customer))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Create([FromBody] Customer c)
        {
            if (c == null)
            {
                return BadRequest();    // 400 Bad request
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad request
            }

            Customer added = await repo.CreateAsync(c);
            return CreatedAtRoute( // 201 Created
                routeName: nameof(GetCustomer),
                routeValues: new { id = added.CustomerID.ToLower() },
                value: added);
        }
        // PUT: api/customers/[id]
        // BODY: Customer (JSON, XML)
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Update(string id, [FromBody] Customer c)
        {
            id = id.ToUpper();
            c.CustomerID = c.CustomerID.ToUpper();
            if (c == null || c.CustomerID != id)
            {
                return BadRequest();    // 400 Bad request
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad request
            }
            var existing = await repo.RetrieveAsync(id);
            if (existing == null)
            {
                return NotFound();  // 404 Resource not found
            }
            await repo.UpdateAsync(id, c);
            return new NoContentResult();   // 204 No content
        }
        // Delete: api/customers/[id]
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == "bad")    // simulating possible error where ID is found but not deleted
            {
                var problemDetails = new ProblemDetails
                {
                    Status = StatusCodes.Status400BadRequest,
                    Type = "https://localhost:5001/customers/failed-to-delete",
                    Title = $"Customer ID {id} found but failed to delete.",
                    Detail = "More details like Company Name, Country, and so on.",
                    Instance = HttpContext.Request.Path
                };
                return BadRequest(problemDetails);
            }
            var existing = await repo.RetrieveAsync(id);
            if (existing == null)
            {
                return NotFound();  // 404 Resource not found
            }
            bool? deleted = await repo.DeleteAsync(id);
            if (deleted.HasValue && deleted.Value)  // short circuit AND
            {
                return new NoContentResult();   // 204 No Content
            }
            else
            {
                return BadRequest( // 400 Bad request
                    $"Customer {id} was found but failed to delete.");
            }
        }
    }
}