using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para EjemploConversion.xaml
    /// </summary>
    public partial class EjemploConversion : Window
    {
        public EjemploConversion()
        {
            InitializeComponent();
            this.DataContext = 5;
        }
    }

    public class YesNoToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is string)) return false;
            return value.ToString().ToLower() == "si";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool)) return "no";
            return (bool)value ? "si" : "no";
        }

    }

    public class DebugDummyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Debugger.Break();
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Debugger.Break();
            return value;
        }
    }
}
