using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Controlador;
using Microsoft.SqlServer.Server;
using Negocio;

namespace Modelo
{
    public class ArticuloNegocio
    {
        public List<Articulo> CrearListaArticulo()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion MarcaDescripcion, M.Id MarcaId, C.Descripcion CategoriaDescripcion, C.Id CategoriaId, A.ImagenUrl, A.Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id";
                datos.SetearConsulta(consulta);
                datos.EjecutarConexion();
                while (datos.Lector.Read())
                {
                    Articulo auxiliar = new Articulo();

                    auxiliar.Id = (int)datos.Lector["Id"];
                    auxiliar.CodigoArticulo = (string)datos.Lector["Codigo"];
                    auxiliar.Nombre = (string)datos.Lector["Nombre"];
                    auxiliar.Descripcion = (string)datos.Lector["Descripcion"];
                    auxiliar.Marca.Descripcion = (string)datos.Lector["MarcaDescripcion"];
                    auxiliar.Marca.Id = (int)datos.Lector["MarcaId"];
                    auxiliar.Categoria.Descripcion = (string)datos.Lector["CategoriaDescripcion"];
                    auxiliar.Categoria.Id = (int)datos.Lector["CategoriaId"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        auxiliar.Imagen = (string)datos.Lector["ImagenUrl"];
                    auxiliar.Precio = (decimal)datos.Lector["Precio"];
                    lista.Add(auxiliar);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public  List<Marca> CrearListaMarca()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Select Id, Descripcion from MARCAS");
                datos.EjecutarConexion();
                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public List<Categoria> CrearListaCategoria()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Select Id, Descripcion from CATEGORIAS");
                datos.EjecutarConexion();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void AgregarArticulo(Articulo nuevo_articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values(@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)";
                datos.SetearConsulta(consulta);
                datos.SetearParametro("@Codigo", nuevo_articulo.CodigoArticulo);
                datos.SetearParametro("@Nombre", nuevo_articulo.Nombre);
                datos.SetearParametro("@Descripcion", nuevo_articulo.Descripcion);
                datos.SetearParametro("@IdMarca", nuevo_articulo.Marca.Id);
                datos.SetearParametro("@IdCategoria", nuevo_articulo.Categoria.Id);
                datos.SetearParametro("@ImagenUrl", nuevo_articulo.Imagen);
                datos.SetearParametro("@Precio", nuevo_articulo.Precio);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void ModificarArticulo(Articulo articulo_modificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "UPDATE ARTICULOS SET Codigo = @CodigoArticulo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio WHERE Id = @Id";
                datos.SetearConsulta(consulta);
                datos.SetearParametro("@id", articulo_modificado.Id);
                datos.SetearParametro("@CodigoArticulo", articulo_modificado.CodigoArticulo);
                datos.SetearParametro("@Nombre", articulo_modificado.Nombre);
                datos.SetearParametro("@Descripcion", articulo_modificado.Descripcion);
                datos.SetearParametro("@IdMarca", articulo_modificado.Marca.Id);
                datos.SetearParametro("@IdCategoria", articulo_modificado.Categoria.Id);
                datos.SetearParametro("@ImagenUrl", articulo_modificado.Imagen);
                datos.SetearParametro("@Precio", articulo_modificado.Precio);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void EliminarArticulo(Articulo articulo_seleccionado)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "delete FROM ARTICULOS where id = @id";
                datos.SetearConsulta(consulta);
                datos.SetearParametro("@id", articulo_seleccionado.Id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }
    }
}

