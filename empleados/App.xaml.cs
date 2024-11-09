using empleados.Model;
using System.Collections.ObjectModel;

namespace empleados
{
    public partial class App : Application
    {

        public static Producto selectedServicio;

        public static ObservableCollection<Producto> ProductosCombos;



        public static Inicio FlyoutPage { get; internal set; }
        public App()
        {
            InitializeComponent();

            MainPage = new Inicio();
        }

      
    }
}
