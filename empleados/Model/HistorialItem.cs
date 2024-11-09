using System;

namespace empleados.Model
{
    public class HistorialItem
    {
        // Nombre del servicio o cita
        public string Nombre { get; set; }

        // Breve descripción o resumen de lo ocurrido en el servicio o cita
        public string Descripcion { get; set; }

        // Ruta de la imagen o recurso para mostrar una imagen representativa
        public string Imagen { get; set; }

        // Fecha en la que se realizó el servicio o la cita
        public DateTime Fecha { get; set; }

        // Precio del servicio o cita (puede ser cero si es una cita gratuita)
        public double Precio { get; set; }

        // Propiedad booleana para identificar si el historial es de un servicio
        public bool EsServicio { get; set; }
    }
}
