using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace empleados.Model
{
    public class Servicio
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public string Calificacion { get; set; }
        public ObservableCollection<Horario> Horarios { get; set; } = new ObservableCollection<Horario>();

    }



    
}