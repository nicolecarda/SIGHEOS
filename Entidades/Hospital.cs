using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hospital
    {
        #region Propiedades

        public int? IdHospital { get; set; }
        public string Nombre { get; set; }

        #endregion

        #region Constuctores

        public Hospital()
        {
        }


        public Hospital(String nombre = null)
        {
            Nombre = nombre;
        }

        #endregion

    }
}
