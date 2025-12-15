using Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoktorKabulDurumuController : ControllerBase
    {
        private readonly DoktorKabulDurumuServices _service;

        public DoktorKabulDurumuController(DoktorKabulDurumuServices service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _service.GetAll();
            return Ok(result);
        }
    }
}
