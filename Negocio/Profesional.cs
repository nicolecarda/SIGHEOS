using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Enumerables;

namespace Negocio
{
    public class Profesional
    {

        #region Metodos publicos

        public static List<Entidades.Profesional> Listar()
        {

            DataTable dt = new DataTable();
            dt = Datos.Evoluciones.Listar();

            List<Entidades.Profesional> listaProfesionales = new List<Entidades.Profesional>();

            foreach (DataRow item in dt.Rows)
            {
                listaProfesionales.Add(ArmarDatos(item));
            }


            return listaProfesionales;
        }

        public static void Eliminar(int idProfesional)
        {
            Datos.Profesionales.Eliminar(idProfesional);
        }

        public static int Grabar(Entidades.Profesional Profesional)
        {
            try
            {
                if (Validar(Profesional, out string error))
                {
                    if (Profesional.IdProfesional == null)
                    {
                        return Insertar(Profesional);
                    }
                    else
                    {
                        return Modificar(Profesional);
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

        public static Entidades.Profesional Obtener(int idProfesional)
        {
            DataTable dt = new DataTable();
            dt = Datos.Profesionales.Obtener(idProfesional);

            return ArmarDatos(dt.Rows[0]);
        }

        public static int Modificar(Entidades.Profesional Profesional)
        {
            Datos.Profesionales.Modificar(Profesional);

            return Profesional.IdProfesional.Value;
        }

        #endregion

        #region Metodos privados

        private static int Insertar(Entidades.Profesional Profesional)
        {
            return Datos.Profesionales.Insertar(Profesional);
        }

        

        private static bool Validar(Entidades.Profesional profesional, out string error)
        {

            error = "";


            if (string.IsNullOrEmpty(profesional.Nombre))
                error += "No se ha ingresado el nombre del profesional;";

            if (string.IsNullOrEmpty(profesional.Apellido))
                error += "No se ha ingresado el apellido del profesional;";

            if (string.IsNullOrEmpty(profesional.Especialidad))
                error += "No se ha ingresado la especialidad del profesional;";

            if (string.IsNullOrEmpty(error))
                return true;
            else
                return false;
        }

        private static Entidades.Profesional ArmarDatos(DataRow item)
        {
            Entidades.Profesional Profesional = new Entidades.Profesional();

            Profesional.IdProfesional = Convert.ToInt32(item["IdProfesional"]);
            Profesional.Nombre = item["Nombre"].ToString();
            Profesional.Apellido = item["Apellido"].ToString();
            Profesional.Especialidad = item["Especialidad"].ToString();
            Profesional.Hospital = (Entidades.Enumerables.Hospitales)(Convert.ToInt32(item["IdHospital"]));
            Profesional.Email = item["Email"].ToString();
            Profesional.Clave = item["Clave"].ToString();
            Profesional.CodigoActivacion = item["CodigoActivacion"].ToString();


            return Profesional;
        }

        #endregion



    }
}
