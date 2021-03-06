using ProyectoRonnieMascaro.Commands.ProductoCommand;
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
    public class ProductosTableViewModel : ViewModelBase
    {
        private ObservableCollection<ProductosModel> listaProductos { get; set; }


        public ObservableCollection<ProductosModel> ListaProductos
        {
            get
            {
                return listaProductos;
            }
            set
            {
                listaProductos = value;
                OnPropertyChanged(nameof(ListaProductos));
            }
        }



        private ObservableCollection<string> ListaNuevaProveedores { get; set; }

        private ObservableCollection<ProductosModel> listaProveedores { get; set; }


        public ObservableCollection<ProductosModel> ListaProveedores
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




        public ICommand LoadProductosCommand { get; set; }



        public ICommand LoadProductoCommand { get; set; }



        public ICommand NewProductoCommand { get; set; }



        public ICommand DeleteProductoCommand { get; set; }



        public ICommand AddToProductCommand { get; set; }



        public ProductosModel SelectedProductos { get; set; }



        private ProductosModel currentProducto { get; set; }

        public ProductosModel CurrentProducto
        {
            get
            {
                return currentProducto;
            }
            set
            {
                currentProducto = value;
                OnPropertyChanged(nameof(CurrentProducto));
            }
        }





        public ProductosTableViewModel()
        {
            ListaProductos = new ObservableCollection<ProductosModel>();
            ListaProveedores = new ObservableCollection<ProductosModel>();
            LoadProductoCommand = new LoadProductoCommand(this);
            LoadProductosCommand = new LoadProductosCommand(this);
            CurrentProducto = new ProductosModel();
            NewProductoCommand = new NewProductoCommand(this);
            DeleteProductoCommand = new DeleteProductoCommand(this);
            AddToProductCommand = new AddToProductCommand(this);
            ListaNuevaProveedores = new ObservableCollection<string>() { "1", "2", "3", "4", "5" };
        }
    }
}


