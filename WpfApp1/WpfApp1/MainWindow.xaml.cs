using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button btn = new Button();
            btn.FontWeight = FontWeights.Bold;

            WrapPanel pnl = new WrapPanel();

            TextBlock txt = new TextBlock();
            txt.Text = "Multi desde código";
            txt.Foreground = Brushes.Blue;
            pnl.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "Color";
            txt.Foreground = Brushes.Red;
            pnl.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "Button";
            pnl.Children.Add(txt);

            btn.Content = pnl;
            pnlMain.Children.Add(btn);

            Button b;

            for(int i = 0; i <= 9; i++)
            {
                b = new Button();
                b.Content = $"{i}";
                b.FontWeight = FontWeights.Bold;

                b.Click += BotonNumericoPulsado;
                b.Click += DepuracionBoton; // Podemos añadir más de un gestor de eventos para el mismo evento

                //b.Click -= DepuracionBoton; // También podemos quitar gestores de eventos

                pnlMain.Children.Add(b);
            }
        }

        private void DepuracionBoton(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Se ha pulsado el botón {((Button)sender).Content}");
        }

        private void BotonNumericoPulsado(object sender, RoutedEventArgs e)
        {
            DisplayCalculadora.Text += ((Button)sender).Content.ToString();
        }

        private void Saludar(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            MessageBox.Show("Date por saludado " + b.Content);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Generado desde XAML");
        }

        private void PnlMain_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You clicked me at " + e.GetPosition(this).ToString());
        }
    }
}
