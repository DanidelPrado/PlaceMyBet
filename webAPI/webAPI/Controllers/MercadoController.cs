﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webAPI.Models;

namespace webAPI.Controllers
{
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
