using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webAPI.Models;

namespace webAPI.Controllers
{
    [Route("api/Apuesta/{action}")]
    public class ApuestaController : ApiController
    {
        // GET: api/Apuesta
        [Authorize(Roles = "Admin")]
        [HttpGet]
        [ActionName("Get")]
        public IEnumerable<Apuesta> Get()
        {
            ApuestaRepository rep = new ApuestaRepository();
            List<Apuesta> lista = rep.retrieve();
            return lista;
        }
        [HttpGet]
        [ActionName("GetDTO")]
        public IEnumerable<ApuestaDTO> GetDTO()
        {
            var repository = new ApuestaRepository();
            List<ApuestaDTO> apuestas = repository.retrieveDTO();
            return apuestas;
        }


        public List<ApuestaDTO2> GetEmailTipo(string email, double tipo)
        {
            var repository = new ApuestaRepository();
            List<ApuestaDTO2> listaApuesta = repository.RetrieveEmailTipo(email, tipo);
            return listaApuesta;
        }

        public List<ApuestaDTO3> GetEmailId(string email, int id)
        {
            var repository = new ApuestaRepository();
            List<ApuestaDTO3> listaApuesta = repository.RetrieveEmailId(email, id);
            return listaApuesta;
        }

        // POST: api/Apuesta
        [Authorize]
        public void Post([FromBody]Apuesta apuesta)
        {
            var repo = new ApuestaRepository();
            repo.Save(apuesta);
        }

        // PUT: api/Apuesta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apuesta/5
        public void Delete(int id)
        {
        }
    }
}
