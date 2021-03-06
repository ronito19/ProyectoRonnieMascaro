using ProyectoRonnieMascaro.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRonnieMascaro.Services
{
    public class ProductoDBHandler
    {
        private static ObservableCollection<ProductosModel> listaProductos = new ObservableCollection<ProductosModel>();

        private static ObservableCollection<string> listaProveedores = new ObservableCollection<string>();

        public static void CargarListaFicticia()
        {
            listaProductos = new ObservableCollection<ProductosModel>();

            var random = new Random();

            for (int i = 001; i < 006; i++)
            {
                ProductosModel pro = new ProductosModel();
                pro._Id = i.ToString();
                pro.Clase = "Gafas Graduadas";
                pro.Marca = "Gucci";
                pro.Tipo = "Lentillas Blandas";
                pro.FechaEntrada = DateTime.Today;
                listaProductos.Add(pro);
            }
        }




        public static bool GuardarProducto(ProductosModel producto)
        {
            bool okguardar = false;

            foreach (ProductosModel pro in listaProductos)
            {
                if (pro._Id == producto._Id)
                {
                    pro.Proveedor = producto.Proveedor;
                    pro.Clase = producto.Clase;
                    pro.Marca = producto.Marca;
                    pro.Tipo = producto.Tipo;
                    pro.Referencia = producto.Referencia;
                    pro.Descripcion = producto.Descripcion;
                    pro.Precio = producto.Precio;
                    pro.FechaEntrada = producto.FechaEntrada;
                    pro.Stock = producto.Stock;
                    okguardar = true;
                    break;
                }

            }

            return okguardar;
        }




        public static bool NuevoProducto(ProductosModel productos)
        {
            bool OKinsertar = false;

            try
            {
                listaProductos.Add(productos);
                OKinsertar = true;
            }
            catch (Exception)
            {

            }
            return OKinsertar;
        }



        public static bool EditProducto(ProductosModel productos)
        {
            bool okGuardar = false;
            foreach (ProductosModel pd in listaProductos)
            {
                if (pd._Id.Equals(productos._Id))
                {
                    pd._Id = productos._Id;
                    pd.Proveedor = productos.Proveedor;
                    pd.Clase = productos.Clase;
                    pd.Marca = productos.Marca;
                    pd.Tipo = productos.Tipo;
                    okGuardar = true;
                }
            }
            return okGuardar;
        }




        public static int BorrarProducto(ProductosModel productos)
        {
            foreach (ProductosModel pd in listaProductos)
            {
                if (pd._Id.Equals(productos._Id))
                {
                    int index = listaProductos.IndexOf(pd);
                    return index;
                }
            }
            return -1;
        }




        public static ObservableCollection<ProductosModel> ObtenerListaProductos()
        {
            return listaProductos;
        }



        public static bool NuevoProveedor(string proveedor)
        {
            bool OKinsertar = false;

            try
            {
                listaProveedores.Add(proveedor);
                OKinsertar = true;
            }
            catch (Exception)
            {

            }
            return OKinsertar;
        }



        public static bool NuevoProveedor(ObservableCollection<string> proveedor)
        {
            bool OKinsertar = false;

            try
            {
                listaProveedores.Add("Proveedor 1");
                OKinsertar = true;
            }
            catch (Exception)
            {

            }
            return OKinsertar;
        }



        public static ObservableCollection<string> ObtenerListaProveedores()
        {
            return listaProveedores;
        }
    }
}
