using ProyectoRonnieMascaro.Services;
using ProyectoRonnieMascaro.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoRonnieMascaro.Commands.ProductoCommand
{
    class AddToProductCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            bool OKinsertar = ProductoDBHandler.NuevoProveedor(proveedor);
        }


        public ObservableCollection<string> proveedor { get; set; }



        private ProductosTableViewModel productosTableViewModel;

        public AddToProductCommand(ProductosTableViewModel productosTableViewModel)
        {
            this.productosTableViewModel = productosTableViewModel;
        }
    }
}
