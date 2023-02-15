using api.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("/")]
    public class ApiController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper; 


        public ApiController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [Produces("application/json")]
        [HttpPost("{query}")]
        public async Task<ActionResult<WordDto>> GetWords(string query){
            var user =  _context.Words.Where(q => q.Searchable.
                StartsWith(query.ToString())).OrderBy(q => q.Searchable).Take(30);

            var userToReturn = _mapper.Map<IEnumerable<WordDto>>(user);
            if (userToReturn == null) return NotFound();
            return Ok(userToReturn);
        }
    }
}