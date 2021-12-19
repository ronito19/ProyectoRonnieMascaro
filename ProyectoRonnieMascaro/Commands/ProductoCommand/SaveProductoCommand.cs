using ProyectoRonnieMascaro.Services;
using ProyectoRonnieMascaro.ViewModels;
using ProyectoRonnieMascaro.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProyectoRonnieMascaro.Commands.ProductoCommand
{
    class SaveProductoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ProductosTableView vista = (ProductosTableView)parameter;

            Console.WriteLine("CODIGO DE BARRAS: " + productosTableViewModel.CurrentProducto._Id);
            Console.WriteLine("REFERENCIA: " + productosTableViewModel.CurrentProducto.Referencia);
            Console.WriteLine("DESCRIPCION: " + productosTableViewModel.CurrentProducto.Descripcion);
            Console.WriteLine("PRECIO: " + productosTableViewModel.CurrentProducto.Precio);
            Console.WriteLine("FECHA ENTRADA: " +vista.datePickerFecha.Text);
            Console.WriteLine("STOCK: " + productosTableViewModel.CurrentProducto.Stock);



            if (productosTableViewModel.CurrentProducto._Id.Equals(""))
            {
                vista.txWarning.Text = "DEBES ESCRIBIR UN CODIGO";
            }
            else if (productosTableViewModel.CurrentProducto.Referencia.Equals("") || productosTableViewModel.CurrentProducto.Referencia is null)
            {
                vista.txWarning.Text = "DEBES ESCRIBIR UNA REFERENCIA";
            }
            else if (productosTableViewModel.CurrentProducto.Descripcion.Equals("") || productosTableViewModel.CurrentProducto.Descripcion is null)
            {
                vista.txWarning.Text = "DEBES ESCRIBIR UNA DESCRIPCION";
            }
            else if (productosTableViewModel.CurrentProducto.Precio.Equals(""))
            {
                vista.txWarning.Text = "DEBES ESCRIBIR UN PRECIO";
            }
            else if (productosTableViewModel.CurrentProducto.FechaEntrada.Equals(""))
            {
                vista.txWarning.Text = "DEBES ESCRIBIR UNA FECHA";
            }
            else if (productosTableViewModel.CurrentProducto.Stock.Equals(""))
            {
                vista.txWarning.Text = "DEBES ESCRIBIR UN NUMERO DE STOCK";
            }
            else
            {
                vista.txWarning.Text = "";
                MessageBoxResult result = MessageBox.Show("¿Deseas realizar los cambios?", "Modificar", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        bool okguardar = ProductoDBHandler.GuardarProducto(productosTableViewModel.CurrentProducto);
                        if (okguardar)
                        {
                            MessageBox.Show("Producto modificado con éxito", "Modificar");
                            vista.E01MostrarDatosProductos1();
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar", "Modificar");

                        }
                        break;

                    case MessageBoxResult.No:
                        break;

                }
            }
        }



        public ProductosTableViewModel productosTableViewModel { get; set; }
        public SaveProductoCommand(ProductosTableViewModel productosTableViewModel)
        {
            this.productosTableViewModel = productosTableViewModel;
        }
    }
    
}
