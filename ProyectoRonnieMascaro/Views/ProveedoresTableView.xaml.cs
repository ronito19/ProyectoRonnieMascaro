using ProyectoRonnieMascaro.Models;
using ProyectoRonnieMascaro.Services;
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

namespace ProyectoRonnieMascaro.Views
{
    /// <summary>
    /// Lógica de interacción para ProveedoresTableView.xaml
    /// </summary>
    public partial class ProveedoresTableView : UserControl
    {
        public ProveedoresTableView()
        {
            InitializeComponent();
            E00Estadoinicial();
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



        private bool editarActivado;

        public bool EditarActivado
        {
            get
            {
                return editarActivado;
            }
            set
            {
                editarActivado = value;
                OnPropertyChanged(nameof(EditarActivado));
            }
        }




        public void E00Estadoinicial()
        {
            stackDatosPro.Visibility = Visibility.Collapsed;

            EditarActivado = false;

            txWarning.Text = "";
        }


        public void E01MostrarDatos()
        {
            stackDatosPro.Visibility = Visibility.Visible;

            btnGuardarDatos.Visibility = Visibility.Collapsed;
            btnBorrarDatos.Visibility = Visibility.Collapsed;
            btnEditarDatos.Visibility = Visibility.Visible;
            btnCrearDatos.Visibility = Visibility.Visible;
            btnAtras.Visibility = Visibility.Collapsed;

            proveedorListView.IsEnabled = true;

            EditarActivado = true;

            txWarning.Text = "";
        }



        public void E02ModificarDatos()
        {

            btnGuardarDatos.Visibility = Visibility.Visible;
            btnBorrarDatos.Visibility = Visibility.Visible;
            btnEditarDatos.Visibility = Visibility.Collapsed;
            btnCrearDatos.Visibility = Visibility.Collapsed;
            btnAtras.Visibility = Visibility.Visible;

            proveedorListView.IsEnabled = false;

            EditarActivado = true;
        }




        public void E03CrearDatos()
        {
            btnGuardarDatos.Visibility = Visibility.Visible;
            btnBorrarDatos.Visibility = Visibility.Visible;
            btnEditarDatos.Visibility = Visibility.Collapsed;
            btnAtras.Visibility = Visibility.Visible;

            proveedorListView.IsEnabled = false;

            EditarActivado = true;
        }



        private void proveedorListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            E01MostrarDatos();
        }




        private void btnEditarDatos_Click(object sender, RoutedEventArgs e)
        {
            E02ModificarDatos();
        }




        private void btnGuardarDatos_Click(object sender, RoutedEventArgs e)
        {
            E01MostrarDatos();

            proveedorListView.IsEnabled = true;
        }




        private void btnBorrarDatos_Click(object sender, RoutedEventArgs e)
        {

            E01MostrarDatos();
            proveedorListView.IsEnabled = true;
        }





       

        private void btnCrearDatos_Click(object sender, RoutedEventArgs e)
        {
            E02ModificarDatos();


            proveedorListView.SelectedIndex = proveedorListView.Items.Count;


        }




        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            E01MostrarDatos();

        }
    }
}

