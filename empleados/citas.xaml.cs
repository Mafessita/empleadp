using empleados.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace empleados;

public partial class citas : ContentPage
{
    public ObservableCollection<Citas> Citas { get; set; }
    public ICommand IrCitasCommand { get; }

    public citas(ObservableCollection<Citas> citas)
    {
        InitializeComponent();
        Citas = citas;
        BindingContext = this;
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
