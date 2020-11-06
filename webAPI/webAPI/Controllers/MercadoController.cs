﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webAPI.Models;

namespace webAPI.Controllers
{
    [Route("api/Mercado/{action}")]
    public class MercadoController : ApiController
    {
        // GET: api/Mercado
        [HttpGet]
        [ActionName("Get")]
        public IEnumerable<Mercado> Get()
        {
            MercadoRepository repository = new MercadoRepository();
            List<Mercado> mercados = repository.retrieve();
            return mercados;
        }

        [HttpGet]
        [ActionName("GetDTO")]
        public IEnumerable<MercadoDTO> GetDTO()
        {
            var repository = new MercadoRepository();
            List<MercadoDTO> mercados = repository.retrieveDTO();
            return mercados;
        }

        [HttpGet]
        [ActionName("GetMercadoId")]
        public List<Mercado> Get(int id, double tipo)
        {
            var repository = new MercadoRepository();
            List<Mercado> listaMercado = repository.RetrieveIdMercado(id, tipo);
            return listaMercado;
        }

        // POST: api/Mercado
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Mercado/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Mercado/5
        public void Delete(int id)
        {
        }
    }
}
