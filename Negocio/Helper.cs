using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Helper
    {

        public void setearColor(int color) { 

        AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearParametro("@color", color);
                datos.Consulta("update color set color=@color;");
                datos.Insertar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public int seleccionarColor()
        {

            AccesoDatos datos = new AccesoDatos();
            int resultado=0;

            try
            {
                
                datos.Consulta("select color FROM color;");
                datos.Leer();
                while (datos.Lector.Read())
                {
                    resultado = (int)datos.Lector["color"];
                }

                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public Dictionary<string, decimal> ObtenerPorcentajeVentasPorMarca()
        {
            Dictionary<string, decimal> porcentajeVentasPorMarca = new Dictionary<string, decimal>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string sql = "SELECT TOP 5  m.Id AS IdMarca, m.Descripcion AS NombreMarca, SUM(a.CantidadVentas) AS CantidadVentas FROM MARCAS m JOIN ARTICULOS a ON m.Id = a.IdMarca GROUP BY m.Id, m.Descripcion";

                datos.Consulta(sql);
                datos.Leer();
                while (datos.Lector.Read())
                {
                    string nombreMarca = datos.Lector["NombreMarca"].ToString();
                    decimal cantidadVentas = Convert.ToDecimal(datos.Lector["CantidadVentas"]);

                    porcentajeVentasPorMarca[nombreMarca] = cantidadVentas;
                    Console.WriteLine(porcentajeVentasPorMarca);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();

            }

            return porcentajeVentasPorMarca;
        }
        
        public Dictionary<string, decimal> ObtenerPorcentajeVentasPorCategoria()
        {
            Dictionary<string, decimal> porcentajeVentasPorCategoria = new Dictionary<string, decimal>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string sql = "SELECT TOP 5 c.Id AS IdCategoria, c.descripcion AS NombreCategoria, SUM(a.CantidadVentas) AS CantidadVentas FROM CATEGORIAS c JOIN ARTICULOS a ON c.Id = a.IdCategoria GROUP BY c.Id, c.descripcion";

                datos.Consulta(sql);
                datos.Leer();
                while (datos.Lector.Read())
                {
                    string nombreCategoria = datos.Lector["NombreCategoria"].ToString();
                    decimal cantidadVentas = Convert.ToDecimal(datos.Lector["CantidadVentas"]);

                    porcentajeVentasPorCategoria[nombreCategoria] = cantidadVentas;
                    Console.WriteLine(porcentajeVentasPorCategoria);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();

            }

            return porcentajeVentasPorCategoria;
        }

        public Dictionary<string, decimal> CalcularPorcentajeVentas(Dictionary<string, decimal> cantidadVentasPorGrupo)
        {
            Dictionary<string, decimal> porcentajeVentas = new Dictionary<string, decimal>();

            decimal totalVentas = cantidadVentasPorGrupo.Values.Sum();

            foreach (var kvp in cantidadVentasPorGrupo)
            {
                string nombreGrupo = kvp.Key;
                decimal cantidadVentas = kvp.Value;

                decimal porcentaje = (cantidadVentas / totalVentas) * 100;
                porcentajeVentas[nombreGrupo] = porcentaje;
            }

            return porcentajeVentas;
        }

        public void MostrarPorcentajes(Dictionary<string, decimal> porcentajes)
        {
            foreach (var kvp in porcentajes)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}%");
            }
        }
    }
}

