using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webAPI.Models;

namespace webAPI.Controllers
{
<<<<<<< HEAD

=======
>>>>>>> 5d2ea20c05167e8c916c2c48d7f94f391f910a0f
    public class MercadoController : ApiController
    {
        // GET: api/Mercado
        public IEnumerable<MercadoDTO> GetDTO()
        {
            var repository = new MercadoRepository();
            List<MercadoDTO> mercados = repository.retrieveDTO();
            return mercados;
        }

        // POST: api/Mercado
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Mercado/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Mercado/5
        public void Delete(int id)
        {
        }
    }
}
