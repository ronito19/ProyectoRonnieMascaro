using ProyectoRonnieMascaro.Commands.ProveedorCommand;
using ProyectoRonnieMascaro.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoRonnieMascaro.ViewModels
{
    public class ProveedoresTableViewModel : ViewModelBase
    {


        private ObservableCollection<ProveedoresModel> listaProveedores { get; set; }

        public ObservableCollection<ProveedoresModel> ListaProveedores
        {
            get
            {
                return listaProveedores;
            }
            set
            {
                listaProveedores = value;
                OnPropertyChanged(nameof(ListaProveedores));
            }
        }

        

        public ICommand LoadProveedoresCommand { get; set; }

        public ICommand LoadProveedorCommand { get; set; }


        public ICommand DeleteProveedorCommand { get; set; }


        public ProveedoresModel SelectedProveedor { get; set; }


        public ProveedoresModel editarActivado { get; set; }


        private ProveedoresModel currentProveedor { get; set; }

        public ProveedoresModel CurrentProveedor
        {
            get
            {
                return currentProveedor;
            }
            set
            {
                currentProveedor = value;
                OnPropertyChanged(nameof(CurrentProveedor));
            }
        }





        public ProveedoresTableViewModel()
        {
            ListaProveedores = new ObservableCollection<ProveedoresModel>();
            LoadProveedoresCommand = new LoadProveedoresCommand(this);
            LoadProveedorCommand = new LoadProveedorCommand(this);
            CurrentProveedor = new ProveedoresModel();
            DeleteProveedorCommand = new DeleteProveedorCommand(this);
        }
    }
}
