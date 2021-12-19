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

namespace ProyectoRonnieMascaro.Commands.ProveedorCommand
{
    class SaveProveedorCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ProveedoresTableView vista = (ProveedoresTableView)parameter;

            Console.WriteLine("NOMBRE: " +proveedoresTableViewModel.CurrentProveedor.Nombre);
            Console.WriteLine("PROVINCIA: " +proveedoresTableViewModel.CurrentProveedor.Provincia);
            Console.WriteLine("TELEFONO: " + +proveedoresTableViewModel.CurrentProveedor.Telefono);
            

            if (proveedoresTableViewModel.CurrentProveedor.Nombre.Equals(""))
            {
                vista.txWarning.Text = "DEBES ESCRIBIR UN NOMBRE";
            }
            else if (proveedoresTableViewModel.CurrentProveedor.Provincia.Equals("") || proveedoresTableViewModel.CurrentProveedor.Provincia is null)
            {
                vista.txWarning.Text = "DEBES ESCRIBIR UNA PROVINCIA";
            }
            else if (proveedoresTableViewModel.CurrentProveedor.Telefono.Equals(""))
            {
                vista.txWarning.Text = "DEBES ESCRIBIR UN TELEFONO";
            }
            else
            {
                vista.txWarning.Text = "";
                MessageBoxResult result = MessageBox.Show("¿Deseas realizar los cambios?", "Modificar", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        bool okguardar = ProveedorDBHandler.GuardarProveedor(proveedoresTableViewModel.CurrentProveedor);
                        if (okguardar)
                        {
                            MessageBox.Show("Proveedor modificado con éxito", "Modificar");
                            vista.E01MostrarDatos();
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



        public ProveedoresTableViewModel proveedoresTableViewModel { get; set; }
        public SaveProveedorCommand(ProveedoresTableViewModel proveedoresTableViewModel)
        {
            this.proveedoresTableViewModel = proveedoresTableViewModel;
        }
    }
}
