using ProyectoRonnieMascaro.Services;
using ProyectoRonnieMascaro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoRonnieMascaro.Commands.ProveedorCommand
{
    public class LoadProveedoresCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ProveedorDBHandler.CargarListaSupuesta();
            proveedoresTableViewModel.ListaProveedores = ProveedorDBHandler.ObtenerListaProveedores();
        }


        public ProveedoresTableViewModel proveedoresTableViewModel;

        public LoadProveedoresCommand(ProveedoresTableViewModel proveedoresTableViewModel)
        {
            this.proveedoresTableViewModel = proveedoresTableViewModel;
        }
    }
}
