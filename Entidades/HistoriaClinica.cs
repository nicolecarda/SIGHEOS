using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    #region Propiedades

    public class HistoriaClinica
    {
        public int? NroHC { get; set; }
        public string NombreLegalPac { get; set; }
        public string NombreAutopercibidoPac { get; set; }
        public string ApellidoPac { get; set; }
        public int EdadPac { get; set; }
        public DateTime FechaNacimientoPac { get; set; }
        public bool SexoPac { get; set; }
        public int DNIPac { get; set; }
        public string DomicilioPac { get; set; }
        public int TelefonoPac { get; set; }
        public bool ObraSocialPac { get; set; }


        #endregion

        #region Constructores

        public HistoriaClinica()
    {
    }


    public HistoriaClinica(DateTime fechaNacimientoPac, bool sexoPac, String nombreLegalPac = null, String nombreAutopercibidoPac = null, String apellidoPac = null, int edadPac = 0, int dniPac = 0, String domicilioPac = null, int telefonoPac = 0, bool obraSocialPac = false)
    {
       
       
        FechaNacimientoPac = fechaNacimientoPac;
        SexoPac = sexoPac;
        NombreLegalPac = nombreLegalPac;
        NombreAutopercibidoPac = nombreAutopercibidoPac;
        ApellidoPac = apellidoPac;
        EdadPac = edadPac;
        DNIPac = dniPac;
        DomicilioPac = domicilioPac;
        TelefonoPac = telefonoPac;
        ObraSocialPac = obraSocialPac;


     }


     #endregion


    }

}
