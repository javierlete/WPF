using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //if (e.Args.Length == 1)
            //    MessageBox.Show("Now opening file: \n\n" + e.Args[0]);
            //
            //MessageBox.Show(this.FindResource("SaludoInicial").ToString());

            // Create the startup window
            // Window2 wnd = new Window2();
            // Do stuff here, e.g. to the window
            // wnd.Title = "Something else";
            // Show the window
            //wnd.Show();

            //MessageBox.Show(new EjemploDialogo().ShowDialog().ToString());
            new EjemploWebBrowser().Show();
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Error no esperado");
            e.Handled = true;
        }
    }
}
