using Microsoft.AspNetCore.Mvc;
using PersonaRest.DBUtil;
using PersonaRest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonaRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {

        private static readonly List<Persona> Personas = new List<Persona>()
        {
            new Persona(1, "Arsene", 1, "Fool", 0),
            new Persona(2, "Pixie", 2, "Lovers", 6),
            new Persona(3, "Jack O' Lantern", 2, "Magician", 1),
            new Persona(4, "Zorro", 3, "Magician", 1),
            new Persona(5, "Bicorn", 4, "Hermit", 9),
            new Persona(6, "Agathion", 3, "Chariot", 7),
            new Persona(7, "Captain Kidd", 5, "Chariot", 7)
        };


        // GET: api/<PersonasController>
        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            ManagePersona mp = new ManagePersona();
            return mp.Get();
            //return Personas;
        }

        // GET api/<PersonasController>/5
        [HttpGet]
        [Route("{personaId}")]
        public Persona Get(int personaId)
        {
            return Personas.Find(p => p.PersonaId == personaId);
        }

        [HttpGet]
        [Route("arcana/{arcana}")]
        public IEnumerable<Persona> GetByArcana(string arcana)
        {
            ManagePersona mp = new ManagePersona();
            return mp.GetByArcana(arcana);
            //List<Persona> lPersonas = Personas.FindAll(p => p.Arcana.Equals(arcana));
            //return lPersonas;
        }

        [HttpGet]
        [Route("level/{level}")]
        public IEnumerable<Persona> GetByLevel(int level)
        {
            List<Persona> lPersonas = Personas.FindAll(p => p.Level.Equals(level));
            return lPersonas;
        }

        [HttpGet]
        [Route("level/{level}/arcana/{arcana}")]
        public IEnumerable<Persona> GetByLevelAndArcana(int level, string arcana)
        {
            ManagePersona mp = new ManagePersona();
            return mp.GetByLevelAndArcana(level, arcana);
            //List<Persona> lPersonas = Personas.FindAll(p => p.Level.Equals(level));
            //List<Persona> lXPersonas = lPersonas.FindAll(p => p.Arcana.Equals(arcana));
            //return lXPersonas;
        }

        [HttpGet]
        [Route("arcanaNo")]
        public IEnumerable<Persona> GetInArcana()
        {
            ManagePersona mp = new ManagePersona();
            return mp.GetInArcana();
        }

        [HttpGet]
        [Route("abc")]
        public IEnumerable<Persona> GetInABC()
        {
            ManagePersona mp = new ManagePersona();
            return mp.GetInABC();
        }

        // POST api/<PersonasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
