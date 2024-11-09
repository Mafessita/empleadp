using System;
using System.Windows.Input;

namespace empleados.Model
{
    public class Horario
    {
        public DateTime Fecha { get; set; }        // Fecha del horario
        public TimeSpan Hora { get; set; }         // Hora del horario
        public string TipoTiempo { get; set; }     // Tipo de tiempo (e.g., "Minutos", "Horas")
        public int Duracion { get; set; }          // Duración en unidades de tiempo
        public string FormularioTitulo { get; set; } = "Agregar Nuevo Horario";

        // Comandos para editar y eliminar
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        // Propiedad para mostrar Fecha y Hora combinadas en un solo formato
        public string FormattedDate => $"{Fecha:dd/MM/yyyy} {Hora:hh\\:mm}";

        public Horario()
        {
            // Valores iniciales
            Fecha = DateTime.Today;
            Hora = DateTime.Now.TimeOfDay;
            TipoTiempo = "Horas";
            Duracion = 1;
        }
    }
}
