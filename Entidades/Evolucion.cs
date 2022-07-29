using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Evolucion
    {
        #region Propiedades

        public int? IdEvolucion { get; set; }
        //public int IdProfesional { get; set; }
        //public int NroHC { get; set; }
        public Profesional Profesional { get; set; }
        public HistoriaClinica HistoriaClinica { get; set; }
        public DateTime Fecha { get; set; }       
        public string Descripcion { get; set; }

        #endregion

        #region Constructores

        public Evolucion()
        {
        }


        public Evolucion(Profesional profesional, HistoriaClinica historiaClinica, String descripcion = null)
        {
            Profesional = profesional;
            HistoriaClinica = historiaClinica;
            Fecha = DateTime.Now;
            Descripcion = descripcion;
        }


        #endregion




    }
}
