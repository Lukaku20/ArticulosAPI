using System;

namespace ArticulosAPI.Models {
     public class Articulo
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Resena { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha { get; set; }
        public string UrlImagen { get; set; }
    }
}