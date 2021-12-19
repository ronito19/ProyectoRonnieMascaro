using ProyectoRonnieMascaro.Commands;
using ProyectoRonnieMascaro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoRonnieMascaro.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public ProveedoresModel Proveedor { get; set; }


        private ViewModelBase selectedViewModel;

        public ViewModelBase SelectedViewModel
        {
            get { return selectedViewModel; }
            set
            {
                selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }


        public ProductosModel Productos { get; set; }


        public ICommand UpdateViewCommand { set; get; }

        public MainViewModel()
        {
            SelectedViewModel = new ViewModelBase();
            UpdateViewCommand = new UpdateViewCommand(this);
            Productos = new ProductosModel();

        }


    }
}
