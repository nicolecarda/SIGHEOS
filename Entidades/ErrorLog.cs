using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ErrorLog
    {
        
            #region Propiedades

            public int? IdErrorLog { get; set; }
            public string Descripcion { get; set; }
            public int? Codigo { get; set; }
            public string Objeto { get; set; }
            public DateTime? Fecha { get; set; }


            #endregion

            #region Constructores

            public ErrorLog()
            {
            }


            public ErrorLog(string descripcion, int codigo = 0, string objeto = null, int? idErrorLog = 0)
            {
                Descripcion = descripcion;
                Codigo = codigo;
                Objeto = objeto;
                Fecha = DateTime.Now;
                IdErrorLog = idErrorLog;
            }

            #endregion


        }
    }

