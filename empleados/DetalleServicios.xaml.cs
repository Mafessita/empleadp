using empleados.Model;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using System.Windows.Input;

namespace empleados
{
    public partial class DetalleServicios : ContentPage
    {
        public Servicio Detalles { get; set; }
        
        public DetalleServicios(Servicio detalle)
        {
            InitializeComponent();
            Detalles = detalle;
            BindingContext = this;
        }

      
    }
}
