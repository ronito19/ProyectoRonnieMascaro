using ProyectoRonnieMascaro.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ProyectoRonnieMascaro
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }




        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



        private bool editarVista;

        private object paginaPrincipal;

        public bool EditarVista
        {
            get
            {
                return editarVista;
            }
            set
            {
                editarVista = value;
                OnPropertyChanged(nameof(EditarVista));
            }
        }



        private void btPrincipal_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
        }

        private void btProveedores_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
