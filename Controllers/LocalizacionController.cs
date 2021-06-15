using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_GEO.Context;
using API_GEO.Entidades;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_GEO.Controllers
{
    [Route("api/geocodificar")]
    [ApiController]
    public class LocalizacionController : ControllerBase
    {
        private readonly AppDbContext context;
        public LocalizacionController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<LocalizacionController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Localizacion.ToList());
        }

        // GET api/<LocalizacionController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Localizacion>> Get(int id)
        {
            var localizacion = await context.Localizacion.FindAsync(id);

            if (localizacion == null)
            {
                return NotFound();
            }
            return localizacion;
        }

        // POST api/<LocalizacionController>
        [HttpPost]
        public async Task<ActionResult<Localizacion>> Post(Localizacion localizacion)
        {
            context.Localizacion.Add(localizacion);
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return AcceptedAtAction("Post", new { id = localizacion.id }, localizacion.id);
            
        }

        // PUT api/<LocalizacionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LocalizacionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
