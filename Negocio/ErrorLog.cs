using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ErrorLog
    {

        #region Metodos publicos

        public static List<Entidades.ErrorLog> Listar()
        {

            DataTable dt = new DataTable();
            dt = Datos.ErroresLog.Listar();

            List<Entidades.ErrorLog> listaErroresLogueo = new List<Entidades.ErrorLog>();

            foreach (DataRow item in dt.Rows)
            {
                listaErroresLogueo.Add(ArmarDatos(item));
            }


            return listaErroresLogueo;
        }




        public static int Grabar(Entidades.ErrorLog errorLog)
        {
            return Datos.ErroresLog.Insertar(errorLog);
        }


        #endregion

        #region Metodos privados



        private static Entidades.ErrorLog ArmarDatos(DataRow item)
        {
          
            try
            {
                Entidades.ErrorLog errorLog = new Entidades.ErrorLog(
                item["Descripcion"].ToString(),
                Convert.ToInt32(item["Codigo"]),
                item["Objeto"].ToString(),
                Convert.ToInt32(item["IdErrorLog"])
                 );

                return errorLog;

            }
            catch (Exception ex)
            {
                Negocio.ErrorLog.Grabar(
                    new Entidades.ErrorLog(
                        ex.Message,
                        ex.HResult,
                        JsonConvert.SerializeObject(item)
                        )
                    );

                throw new Exception(ex.Message);

            }

            #endregion


        }

    }
    }
