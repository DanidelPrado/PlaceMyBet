﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webAPI.Models
{
    public class Apuesta
    {
        public Apuesta(int id_Apuesta, double tipo_Mercado, double cuota, double dinero, string fecha, int id_Mercado, string email, string tipo_Cuota)
        {
            Id_Apuesta = id_Apuesta;
            Tipo_Mercado = tipo_Mercado;
            Cuota = cuota;
            Dinero = dinero;
            Fecha = fecha;
            Id_Mercado = id_Mercado;
            Email = email;
            Tipo_Cuota = tipo_Cuota;
        }

        public int Id_Apuesta { get; set; }
        public double Tipo_Mercado { get; set; }
        public double Cuota { get; set; }
        public double Dinero { get; set; }
        public string Fecha { get; set; }
        public int Id_Mercado { get; set; }
        public string Email { get; set; }
        public string Tipo_Cuota { get; set; }
    }

    public class ApuestaDTO
    {
        public ApuestaDTO(string email, double tipo_Mercado, double cuota, string tipo_Cuota, double dinero, string fecha)
        {
            Email = email;
            Tipo_Mercado = tipo_Mercado;
            Cuota = cuota;
            Tipo_Cuota = tipo_Cuota;
            Dinero = dinero;
            Fecha = fecha;
        }

        public string Email { get; set; }
        public double Tipo_Mercado { get; set; }
        public double Cuota { get; set; }
        public string Tipo_Cuota { get; set; }
        public double Dinero { get; set; }
        public string Fecha { get; set; }
    }
    //Ejercicio 2
    public class ApuestaCuota
    {
        public ApuestaCuota(string nombre, double dinero, int id_Mercado)
        {
            Nombre = nombre;
            Dinero = dinero;
            Id_Mercado = id_Mercado;
        }

        public double Dinero { get; set; }
        public string Nombre { get; set; }
        public int Id_Mercado { get; set; }
    }

}