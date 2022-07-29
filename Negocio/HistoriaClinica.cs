using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class HistoriaClinica
    {
        #region Metodos publicos

        public static List<Entidades.HistoriaClinica> Listar()
        {

            DataTable dt = new DataTable();
            dt = Datos.HistoriasClinicas.Listar();

            List<Entidades.HistoriaClinica> listaHistoriasClinicas = new List<Entidades.HistoriaClinica>();

            foreach (DataRow item in dt.Rows)
            {
                listaHistoriasClinicas.Add(ArmarDatos(item));
            }


            return listaHistoriasClinicas;
        }

        public static void Eliminar(int NroHC)
        {
            Datos.HistoriasClinicas.Eliminar(NroHC);
        }

        public static int Grabar(Entidades.HistoriaClinica historiaClinica)
        {
            try
            {
                if (Validar(historiaClinica, out string error))
                {
                    if (historiaClinica.NroHC == null)
                    {
                        return Insertar(historiaClinica);
                    }
                    else
                    {
                        return Modificar(historiaClinica);
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

        public static Entidades.HistoriaClinica Obtener(int NroHC)
        {
            DataTable dt = new DataTable();
            dt = Datos.HistoriasClinicas.Obtener(NroHC);

            return ArmarDatos(dt.Rows[0]);
        }

        public static int Modificar(Entidades.HistoriaClinica historiaClinica)
        {
            Datos.HistoriasClinicas.Modificar(historiaClinica);

            return historiaClinica.NroHC.Value;
        }

        #endregion

        #region Metodos privados

        private static int Insertar(Entidades.HistoriaClinica historiaClinica)
        {
            return Datos.HistoriasClinicas.Insertar(historiaClinica);
        }

       

        private static bool Validar(Entidades.HistoriaClinica historiaClinica, out string error)
        {
            error = "";

          

            if (string.IsNullOrEmpty(historiaClinica.NombreLegalPac))
                error += "No se ha ingresado el nombre del paciente;";

            if (string.IsNullOrEmpty(historiaClinica.ApellidoPac))
                error += "No se ha ingresado el apellido del paciente;";

            if (historiaClinica.EdadPac <= 0)
                error += "La Edad ingresada no es válida. Tiene que ser mayor a 0; ";

            if (historiaClinica.DNIPac <= 0)
                error += "El DNI ingresado es inválido; ";

            if (string.IsNullOrEmpty(error))
                return true;
            else
                return false;
        }

        private static Entidades.HistoriaClinica ArmarDatos(DataRow item)
        {
            Entidades.HistoriaClinica historiaClinica = new Entidades.HistoriaClinica();

            historiaClinica.NroHC = Convert.ToInt32(item["NroHC"]);
            historiaClinica.NombreLegalPac = item["NombreLegalPac"].ToString();
            historiaClinica.NombreAutopercibidoPac = item["NombreAutopercibidoPac"].ToString();
            historiaClinica.ApellidoPac = item["ApellidoPac"].ToString();
            historiaClinica.EdadPac = Convert.ToInt32(item["EdadPac"]);
            historiaClinica.FechaNacimientoPac = Convert.ToDateTime(item["FechaNacimientoPac"]);
            historiaClinica.DNIPac = Convert.ToInt32(item["DNIPac"]);
            historiaClinica.DomicilioPac = item["DomicilioPac"].ToString();
            historiaClinica.TelefonoPac = Convert.ToInt32(item["TelefonoPac"]);

            return historiaClinica;
        }

        #endregion


    }
}
