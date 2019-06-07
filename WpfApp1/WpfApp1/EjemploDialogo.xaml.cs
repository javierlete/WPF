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
    /// Lógica de interacción para EjemploDialogo.xaml
    /// </summary>
    public partial class EjemploDialogo : Window
    {
        public EjemploDialogo(string pregunta, string respuestaPorDefecto = "")
        {
            InitializeComponent();

            txtAnswer.Text = respuestaPorDefecto;
            lblQuestion.Content = pregunta;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txtAnswer.Focus();
            txtAnswer.SelectAll();
        }

        private void BtnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        public string Answer
        {
            get { return txtAnswer.Text; }
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            //No mejora la situación de pérdida de foco
            Activate();
        }
    }
}
