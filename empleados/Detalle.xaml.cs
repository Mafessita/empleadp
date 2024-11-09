using System.Collections.ObjectModel;
using System.Runtime.ConstrainedExecution;
using empleados.Model;


namespace empleados;
public partial class Detalle : ContentPage
{
    public ObservableCollection<Citas> Citas { get; set; }
    public ObservableCollection<Servicio> Servicio { get; set; }  // Cambié el nombre a "Servicios" para mayor claridad

    public Detalle()
    {
        InitializeComponent();

        // Inicialización de colecciones
        Citas = new ObservableCollection<Citas>();
        Servicio = new ObservableCollection<Servicio>();

        // Agregando servicios
        Servicio.Add(new Servicio
        {
            Nombre = "Degradado",
            Imagen = "dotnet_bot.png",
            Calificacion = "lorem",
        });

        Servicio.Add(new Servicio
        {
            Nombre = "Taper",
            Imagen = "corte_peinado.png",
            Calificacion = "lorem",
        });

        Servicio.Add(new Servicio
        {
            Nombre = "Mohicano",
            Imagen = "mohicano.jpg",
            Calificacion = "lorem",
        });

        Servicio.Add(new Servicio
        {
            Nombre = "Fade V",
            Imagen = "fade_v.jpg",
            Calificacion = "lorem",
        });

        ColeccionServicio.ItemsSource = Servicio;

        // Agregando citas
        Citas.Add(new Citas
        {
            Nombre = "Espuma",
            Imagen = "producto_1.jpg",
            Descripcion = "Lorem",
        });

        Citas.Add(new Citas
        {
            Nombre = "Gel",
            Imagen = "producto_2.jpg",
            Descripcion = "Lorem",
        });

        ColeccionCitas.ItemsSource = Citas;
    }

   

    private async void VerMaServicios(object sender, EventArgs e)  // Cambié a "VerMasServicios" para mayor claridad
    {
        // Navegar a la página de servicios
        await Navigation.PushAsync(new servicio(Servicio));
    }

    private async void VerMasCitas(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new citas(Citas));
    }

    private void IrServicio(object sender, TappedEventArgs e)
    {
        var frame = (Frame)sender;
        var itemSelected = frame.BindingContext as Servicio;

        if (itemSelected != null)
        {
            // Navegar a la página "DetalleServicios" pasando el objeto seleccionado
            NavigationToPage(new DetalleServicios(itemSelected));
        }
    }

    private void IrCitas(object sender, TappedEventArgs e)
    {
        var frame = (Frame)sender;
        var itemSelected = frame.BindingContext as Citas;

        if (itemSelected != null)
        {
            NavigationToPage(new DetalleCitas(itemSelected));
        }
    }


    private void NavigationToPage(ContentPage page)
    {
        if (App.FlyoutPage != null)
        {
            App.FlyoutPage.Detail.Navigation.PushAsync(page);
            App.FlyoutPage.IsPresented = false;
        }
    }
}
