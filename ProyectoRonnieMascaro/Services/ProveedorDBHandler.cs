using ProyectoRonnieMascaro.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRonnieMascaro.Services
{
    public class ProveedorDBHandler
    {
        public static ObservableCollection<ProveedoresModel> listaProveedores = new ObservableCollection<ProveedoresModel>();

        public static void CargarListaSupuesta()
        {
            listaProveedores = new ObservableCollection<ProveedoresModel>();

            for (int i = 1; i < 11; i++)
            {
                ProveedoresModel p = new ProveedoresModel();
                p._Id = i.ToString();
                p.Nombre = " Proveedor " + i.ToString();
                p.Provincia = " Toledo ";
                p.Telefono = 123456789;
                listaProveedores.Add(p);
            }
        }




        public static bool GuardarProveedor(ProveedoresModel proveedor)
        {
            bool okguardar = false;

            foreach (ProveedoresModel p in listaProveedores)
            {
                if (p._Id == proveedor._Id)
                {
                    p.Nombre = proveedor.Nombre;
                    p.Provincia = proveedor.Provincia;
                    p.Telefono = proveedor.Telefono;
                    okguardar = true;
                    break;
                }

            }

            return okguardar;
        }




        public static bool NuevoProveedor(ProveedoresModel p)
        {
            bool OKinsertar = false;

            try
            {
                listaProveedores.Add(p);
                OKinsertar = true;
            }
            catch (Exception) { }

            return OKinsertar;
        }




        public static int BorrarProveedor(ProveedoresModel proveedor)
        {
            foreach (ProveedoresModel p in listaProveedores)
            {
                if (p._Id.Equals(proveedor._Id))
                {
                    int index = listaProveedores.IndexOf(p);
                    return index;
                }
            }
            return -1;
        }




        public static void ModificarProveedor(ProveedoresModel proveedor, int pos)
        {

            listaProveedores[pos] = proveedor;
        }




        public static void ActualizarProveedor()
        {
            listaProveedores = ObservableCollection<ProveedoresModel>();

            foreach (ProveedoresModel proveedor in listaProveedores)
            {


            }
        }






        private static ObservableCollection<T> ObservableCollection<T>()
        {
            throw new NotImplementedException();
        }



        public static ObservableCollection<ProveedoresModel> ObtenerListaProveedores()
        {
            return listaProveedores;
        }
    }
}
