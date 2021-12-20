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
    /// Lógica de interacción para ProductosTableView.xaml
    /// </summary>
    public partial class ProductosTableView : UserControl
    {
        public ProductosTableView()
        {
            InitializeComponent();

            E00EstadoInicial1();
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



        public void E00EstadoInicial1()
        {
            stackDatosProductos.Visibility = Visibility.Collapsed;

            EditarActivado = false;

            txWarning.Text = "";
        }



        public void E01MostrarDatosProductos1()
        {
            stackDatosProductos.Visibility = Visibility.Visible;

            btGuardarProducto.Visibility = Visibility.Collapsed;
            btBorrarProducto.Visibility = Visibility.Collapsed;
            btEditarProducto.Visibility = Visibility.Visible;
            btCrearProducto.Visibility = Visibility.Visible;
            btAtras.Visibility = Visibility.Collapsed;

            productoListView.IsEnabled = true;

            EditarActivado = false;

            txWarning.Text = "";
        }



        public void E02ModificarProductos1()
        {


            btGuardarProducto.Visibility = Visibility.Visible;
            btBorrarProducto.Visibility = Visibility.Visible;
            btEditarProducto.Visibility = Visibility.Collapsed;
            btCrearProducto.Visibility = Visibility.Collapsed;
            btAtras.Visibility = Visibility.Visible;

            productoListView.IsEnabled = false;

            EditarActivado = true;
        }




        public void E03CrearProductos()
        {
            btGuardarProducto.Visibility = Visibility.Visible;
            btBorrarProducto.Visibility = Visibility.Visible;
            btEditarProducto.Visibility = Visibility.Collapsed;
            btAtras.Visibility = Visibility.Visible;

            productoListView.IsEnabled = false;

            EditarActivado = true;
        }





        private void productosListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            E01MostrarDatosProductos1();
        }




        private void btEditarProducto_Click(object sender, RoutedEventArgs e)
        {
            E02ModificarProductos1();
        }




        private void btGuardarProducto_Click(object sender, RoutedEventArgs e)
        {
            E01MostrarDatosProductos1();

            productoListView.IsEnabled = true;
        }




        private void btBorrarProducto_Click(object sender, RoutedEventArgs e)
        {
            
            E01MostrarDatosProductos1();
            productoListView.IsEnabled = true;
        }




        private void btnAceptarProveedor_Click(object sender, RoutedEventArgs e)
        {
            dialogProveedores.IsOpen = false;
            cmbListaProveedores.SelectedIndex = cmbListaProveedores.Items.Count;
        }




        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }




        private void btnNuevoProveedor_Click(object sender, RoutedEventArgs e)
        {
            dialogProveedores.IsOpen = false;
            cmbListaProveedores.SelectedIndex = cmbListaProveedores.Items.Count;
        }




        private void btCrearProducto_Click(object sender, RoutedEventArgs e)
        {
            
            E02ModificarProductos1();
            productoListView.SelectedIndex = productoListView.Items.Count;
        }




        private void btAtras_Click(object sender, RoutedEventArgs e)
        {
            E01MostrarDatosProductos1();
        }
    }
}
