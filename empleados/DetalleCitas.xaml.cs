using empleados.Model;
using Microsoft.Maui.Controls;
using System.Threading.Tasks;

namespace empleados
{
    public partial class DetalleCitas : ContentPage
    {
        public Citas DetalleCita { get; set; }

        public DetalleCitas(Citas detalle)
        {
            InitializeComponent();
            DetalleCita = detalle;
            BindingContext = DetalleCita;
        }

        // M�todo para manejar el bot�n "Cancelar cita"
        private async void OnCancelarCitaClicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert("Confirmar", "�Est�s seguro de que deseas cancelar esta cita?", "S�", "No");
            if (confirm)
            {
                // Aqu� puedes eliminar la cita de la base de datos o de la colecci�n
                await DisplayAlert("Cancelada", "La cita ha sido cancelada.", "OK");

                // Regresar a la p�gina anterior despu�s de cancelar
                await Navigation.PopAsync();
            }
        }

        // M�todo para manejar el bot�n "Completado"
        private async void OnCompletadoClicked(object sender, EventArgs e)
        {
            // Aqu� puedes actualizar el estado de la cita en la base de datos
            DetalleCita.Descripcion = "Completado"; // Ejemplo de c�mo marcar como completado en la clase
            await DisplayAlert("Completado", "La cita ha sido marcada como completada.", "OK");

        }
    }
}
