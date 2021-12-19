using ProyectoRonnieMascaro.Services;
using ProyectoRonnieMascaro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoRonnieMascaro.Commands.ProductoCommand
{
    class LoadProductosCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ProductoDBHandler.CargarListaFicticia();
            productosTableViewModel.ListaProductos = ProductoDBHandler.ObtenerListaProductos();
        }



        public ProductosTableViewModel productosTableViewModel;

        public LoadProductosCommand(ProductosTableViewModel productosTableViewModel)
        {
            this.productosTableViewModel = productosTableViewModel;
        }
    }
}
