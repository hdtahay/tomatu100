using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODELS;
using System.Collections;
using BLL.Repositorio;

namespace BLL
{
    public class ClassColorBLL
    {
        BDColoresEntities db;

        //Utilizarlo en la lógica de negocio siempre
        public IEnumerable MostrarProductos()
        {
            db = new BDColoresEntities();
            GenericRepository<Producto> Rep = new GenericRepository<Producto>(db);
            var consulta = Rep.ListarTodoConFiltro(w => w.estado_producto == true); //podemos agregar más condiciones
            return consulta.ToList();
        }

        public IEnumerable MostrarClientes()
        {
            db = new BDColoresEntities();
            GenericRepository<Cliente> Rep = new GenericRepository<Cliente>(db);
            var consulta = Rep.ListarTodoConFiltro(w => w.estado_cliente == true); //podemos agregar más condiciones
            return consulta.ToList();
        }

        public IEnumerable MostrarEmpleados()
        {
            db = new BDColoresEntities();
            GenericRepository<Empleado> Rep = new GenericRepository<Empleado>(db);
            var consulta = Rep.ListarTodoConFiltro(w => w.estado_empleado == true); //podemos agregar más condiciones
            return consulta.ToList();
        }

        public string NuevoProducto(string _descripcion, string descri, int descuento)
        {
            string respuesta = "";
            Producto objeto = new Producto();
            try
            {
                db = new BDColoresEntities();
                GenericRepository<Producto> Repo = new GenericRepository<Producto>(db);
                if (Repo.ListarTodoConFiltro(w => w.nombre_producto == _descripcion).Count() >= 1)
                {
                    respuesta = "Producto ya existente";
                }
                else
                {
                    objeto.nombre_producto = _descripcion;
                    objeto.descripcion_producto = descri;
                    objeto.estado_producto = true;
                    objeto.porcentaje_descuento = descuento;
                    Repo.Agregar(objeto);
                    respuesta = "Producto agregado con éxito";
                }
            }
            catch (Exception error)
            {
                respuesta = "Error al grabar " + error.Message;
            }
            return respuesta;
        }

        public string NuevoEmpleado(string nombre, string apellido, string direccion, string telefono)
        {
            string respuesta = "";
            Empleado objeto = new Empleado();
            try
            {
                db = new BDColoresEntities();
                GenericRepository<Empleado> Repo = new GenericRepository<Empleado>(db);
                if (Repo.ListarTodoConFiltro(w => w.nombre_empleado == nombre && w.apellido_empleado == apellido).Count() >= 1)
                {
                    respuesta = "Empleado ya existente";
                }
                else
                {
                    objeto.nombre_empleado = nombre;
                    objeto.apellido_empleado = apellido;
                    objeto.estado_empleado = true;
                    objeto.direccion_empleado = direccion;
                    objeto.telefono_empleado = telefono;
                    Repo.Agregar(objeto);
                    respuesta = "Empleado agregado con éxito";
                }
            }
            catch (Exception error)
            {
                respuesta = "Error al grabar " + error.Message;
            }
            return respuesta;
        }

        public string NuevoCliente(string nombre, string apellido, string nit)
        {
            string respuesta = "";
            Cliente objeto = new Cliente();
            try
            {
                db = new BDColoresEntities();
                GenericRepository<Cliente> Repo = new GenericRepository<Cliente>(db);
                if (Repo.ListarTodoConFiltro(w => (w.nombre_cliente == nombre && w.apellido_cliente == apellido)).Count() >= 1)
                {
                    respuesta = "Cliente ya existente";
                }
                else
                {
                    objeto.nombre_cliente = nombre;
                    objeto.apellido_cliente = apellido;
                    objeto.estado_cliente = true;
                    objeto.nit_cliente = nit;
                    Repo.Agregar(objeto);
                    respuesta = "Cliente agregado con éxito";
                }
            }
            catch (Exception error)
            {
                respuesta = "Error al grabar " + error.Message;
            }
            return respuesta;
        }

        public string ActualizarProducto(Producto objeto)
        {
            string respuesta = "";
            try
            {
                db = new BDColoresEntities();
                GenericRepository<Producto> Repo = new GenericRepository<Producto>(db);
                Repo.Actualizar(objeto);
                respuesta = "El producto ha sido actualizado";
            }
            catch (Exception error)
            {

                respuesta = "Error al actualizar " + error.Message;
            }
            return respuesta;
        }

        public string ActualizarEmpleado(Empleado objeto)
        {
            string respuesta = "";
            try
            {
                db = new BDColoresEntities();
                GenericRepository<Empleado> Repo = new GenericRepository<Empleado>(db);
                Repo.Actualizar(objeto);
                respuesta = "El empleado ha sido actualizado";
            }
            catch (Exception error)
            {

                respuesta = "Error al actualizar " + error.Message;
            }
            return respuesta;
        }

        public string ActualizarCliente(Cliente objeto)
        {
            string respuesta = "";
            try
            {
                db = new BDColoresEntities();
                GenericRepository<Cliente> Repo = new GenericRepository<Cliente>(db);
                Repo.Actualizar(objeto);
                respuesta = "El cliente ha sido actualizado";
            }
            catch (Exception error)
            {

                respuesta = "Error al actualizar " + error.Message;
            }
            return respuesta;
        }

        public IEnumerable BuscaProducto(string cadena)
        {
            db = new BDColoresEntities();
            GenericRepository<Producto> Rep = new GenericRepository<Producto>(db);
            var consulta = Rep.ListarTodoConFiltro(w => w.nombre_producto == cadena && w.estado_producto == true);
            return consulta.ToList();
        }

        public IEnumerable BuscaEmpleado(string cadena)
        {
            db = new BDColoresEntities();
            GenericRepository<Empleado> Rep = new GenericRepository<Empleado>(db);
            var consulta = Rep.ListarTodoConFiltro(w => (w.nombre_empleado == cadena || w.apellido_empleado == cadena) && w.estado_empleado == true);
            return consulta.ToList();
        }

        public IEnumerable BuscaCliente(string cadena)
        {
            db = new BDColoresEntities();
            GenericRepository<Cliente> Rep = new GenericRepository<Cliente>(db);
            var consulta = Rep.ListarTodoConFiltro(w => (w.nombre_cliente == cadena || w.apellido_cliente == cadena) && w.estado_cliente == true);
            return consulta.ToList();
        }

        public string EliminarProducto(Producto objeto)
        {
            string respuesta = "";
            try
            {
                db = new BDColoresEntities();
                GenericRepository<Producto> Repo = new GenericRepository<Producto>(db);
                Repo.Actualizar(objeto);
                respuesta = "El producto ha sido eliminado";
            }
            catch (Exception error)
            {

                respuesta = "Error al actualizar " + error.Message;
            }
            return respuesta;
        }

        public string EliminarEmpleado(Empleado objeto)
        {
            string respuesta = "";
            try
            {
                db = new BDColoresEntities();
                GenericRepository<Empleado> Repo = new GenericRepository<Empleado>(db);
                Repo.Actualizar(objeto);
                respuesta = "El empleado ha sido eliminado";
            }
            catch (Exception error)
            {

                respuesta = "Error al actualizar " + error.Message;
            }
            return respuesta;
        }

        public string EliminarCliente(Cliente objeto)
        {
            string respuesta = "";
            try
            {
                db = new BDColoresEntities();
                GenericRepository<Cliente> Repo = new GenericRepository<Cliente>(db);
                Repo.Actualizar(objeto);
                respuesta = "El cliente ha sido eliminado";
            }
            catch (Exception error)
            {

                respuesta = "Error al actualizar " + error.Message;
            }
            return respuesta;
        }
    }
}
