﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MADERERA_HRS.Models
{
    public class Carrito_Cotizacion
    {
        public int Id_Carrito_Cotizacion { get; set; }
        public int Id_Usuario { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }
        public string Medidas { get; set; }
        public Usuario Usuario { get; set; }
    }
}
