using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("/")]
    public class ApiController : ControllerBase
    {
        private readonly DataContext _context;

        public ApiController(DataContext context)
        {
            _context = context;
        }
        [Produces("application/json")]
        [HttpPost("{query}")]
        public async Task<ActionResult<Word>> GetWords(string query){
            var user =  _context.Words.Where(q => q.Searchable.
                StartsWith(query.ToString())).OrderBy(q => q.Searchable).Take(30);

            if (user == null) return NotFound();
            return Ok(user);
        }
    }
}