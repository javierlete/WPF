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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para EjemploDialogoMain.xaml
    /// </summary>
    public partial class EjemploDialogoMain : Window
    {
        public EjemploDialogoMain()
        {
            InitializeComponent();
        }

        private void BtnMostrarDialogo_Click(object sender, RoutedEventArgs e)
        {
            EjemploDialogo ed = new EjemploDialogo(this, "Dame tu nombre:", "Javier Lete");

            if(ed.ShowDialog() == true)
            {
                txtResultado.Text = ed.Answer;
            }
        }
    }
}
