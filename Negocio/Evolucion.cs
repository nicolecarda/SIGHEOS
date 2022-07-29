using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class Evolucion
    {

        #region Metodos publicos

        public static List<Entidades.Evolucion> Listar()
        {

            DataTable dt = new DataTable();
            dt = Datos.Evoluciones.Listar();

            List<Entidades.Evolucion> listaEvoluciones = new List<Entidades.Evolucion>();

            foreach (DataRow item in dt.Rows)
            {
                listaEvoluciones.Add(ArmarDatos(item));
            }


            return listaEvoluciones;
        }

        public static void Eliminar(int idEvolucion)
        {
            Datos.Evoluciones.Eliminar(idEvolucion);
        }

        public static int Grabar(Entidades.Evolucion Evolucion)
        {
            try
            {
                if (Validar(Evolucion, out string error))
                {
                    if (Evolucion.IdEvolucion == null)
                    {
                        return Insertar(Evolucion);
                    }
                    else
                    {
                        return Modificar(Evolucion);
                    }
                }
                else
                    throw new Exception(error);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static Entidades.Evolucion Obtener(int idEvolucion)
        {
            DataTable dt = new DataTable();
            dt = Datos.Evoluciones.Obtener(idEvolucion);

            return ArmarDatos(dt.Rows[0]);
        }


        public static int Modificar(Entidades.Evolucion Evolucion)
        {
            Datos.Evoluciones.Modificar(Evolucion);

            return Evolucion.IdEvolucion.Value;
        }

        #endregion

        #region Metodos privados

        private static int Insertar(Entidades.Evolucion Evolucion)
        {
            return Datos.Evoluciones.Insertar(Evolucion);
        }

       

        private static bool Validar(Entidades.Evolucion evolucion, out string error)
        {
            error = "";
           

            if (evolucion.Profesional == null)
                error += "No se ha ingresado ningún profesional;";

            if(evolucion.HistoriaClinica == null)

            if (string.IsNullOrEmpty(evolucion.Descripcion))
                error += "La evolución no posee ningún contenido ";

            if (string.IsNullOrEmpty(error))
                return true;
            else
                return false;
        }

        private static Entidades.Evolucion ArmarDatos(DataRow item)
        {
            Entidades.Evolucion Evolucion = new Entidades.Evolucion();

            Evolucion.IdEvolucion = Convert.ToInt32(item["IdEvolucion"]);
            Evolucion.Profesional = Negocio.Profesional.Obtener(Convert.ToInt32(item["IdProfesional"]));
            Evolucion.Fecha = Convert.ToDateTime(item["Fecha"]);
            Evolucion.Descripcion = item["Descripcion"].ToString();

            return Evolucion;
        }

        #endregion

    }
}
