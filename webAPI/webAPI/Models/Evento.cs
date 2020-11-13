using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webAPI.Models
{
    public class Evento
    {
        public Evento(string id_evento, string local, string visitante, string fecha)
        {
            Id_evento = id_evento;
            Local = local;
            Visitante = visitante;
            Fecha = fecha;
        }

        public string Id_evento { get; set; }
        public string Local { get; set; }
        public string Visitante { get; set; }
        public string Fecha { get; set; }
    }

    public class EventoDTO
    {
        public EventoDTO(string local, string visitante, string fecha)
        {
            Local = local;
            Visitante = visitante;
            Fecha = fecha;
        }

        public string Local { get; set; }
        public string Visitante { get; set; }
        public string Fecha { get; set; }
    }
    // Ejercicio 1
    public class EventoIdEvento
    {
        public EventoIdEvento(string local, string visitante, double tipo_mercado)
        {
            Local = local;
            Visitante = visitante;
            Tipo_Mercado = tipo_mercado;
        }

        public string Local { get; set; }
        public string Visitante { get; set; }
        public double Tipo_Mercado { get; set; }
    }

}