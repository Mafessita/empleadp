namespace empleados;

public partial class Perfil : ContentPage
{
	public Perfil()
	{
		InitializeComponent();
	}


    private async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        bool confirmDelete = await DisplayAlert("Confirmaci�n", "�Est�s seguro de que deseas eliminar este perfil?", "S�", "No");
        if (confirmDelete)
        {
            // L�gica de eliminaci�n del perfil
            // Aqu� podr�as llamar a un m�todo de servicio o eliminar los datos localmente
            await DisplayAlert("Eliminado", "El perfil ha sido eliminado exitosamente.", "OK");
            // Redirigir o actualizar la p�gina si es necesario
        }
    }
}

