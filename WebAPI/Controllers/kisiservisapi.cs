using Business;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class kisiservisapi
    {
        [ApiController]
        [Route("api/[controller]")]
        public class KisiController : ControllerBase
        {
            private readonly IkisiServis _kisiServis;
            public KisiController(IkisiServis ks) => _kisiServis = ks;

            [HttpGet] public IActionResult GetAll() => Ok(_kisiServis.GetAll());
            [HttpGet("{id}")] public IActionResult Get(int id) => Ok(_kisiServis.GetById(id));
            [HttpPost] public IActionResult Create(KayitliKisiListe k) { _kisiServis.Add(k); return Created(); }
            // vs.
        }

    }
}
