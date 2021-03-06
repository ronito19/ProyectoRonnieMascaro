using ProyectoRonnieMascaro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoRonnieMascaro.Commands.ProductoCommand
{
    class LoadProductoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            productosTableViewModel.CurrentProducto = (Models.ProductosModel)parameter;
        }



        public ProductosTableViewModel productosTableViewModel { get; set; }

        public LoadProductoCommand(ProductosTableViewModel productosTableViewModel)
        {
            this.productosTableViewModel = productosTableViewModel;
        }
    }
}
