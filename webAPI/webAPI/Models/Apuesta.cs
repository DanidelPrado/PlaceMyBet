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

    public class ApuestaDTO2
    {
        public int Id_Mercado { get; set; }
        public string Tipo_Cuota { get; set; }
        public double Cuota { get; set; }
        public double Dinero { get; set; }

        public ApuestaDTO2(string tipo_cuota, double cuota, double dinero, int id_mercado)
        {
            Tipo_Cuota = tipo_cuota;
            Cuota = cuota;
            Dinero = dinero;
            Id_Mercado = id_mercado;
        }
    }
    public class ApuestaDTO3
    {
        public double Tipo_Mercado { get; set; }
        public string Tipo_Cuota { get; set; }
        public double Cuota { get; set; }
        public double Dinero { get; set; }

        public ApuestaDTO3(double tipo_mercado, string tipo_cuota, double cuota, double dinero)
        {
            Tipo_Mercado = tipo_mercado;
            Tipo_Cuota = tipo_cuota;
            Cuota = cuota;
            Dinero = dinero;
        }
    }
}