using Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TamamlanmaDurumuController : ControllerBase
    {
        private readonly TamamlanmaDurumuService _service;

        public TamamlanmaDurumuController(TamamlanmaDurumuService service)
        {
            _service = service;
        }

         [HttpGet]
        public IActionResult GetAll()
        {
            var list = _service.GetAll();
            return Ok(list);
        }
    }
}
