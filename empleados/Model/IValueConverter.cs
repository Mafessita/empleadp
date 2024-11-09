using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace empleados.Model
{
    public class EstadoColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var estado = value as string;
            return estado == "Completo" ? Colors.Green : Colors.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
