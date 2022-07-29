using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasSIGHEOS
{

    [TestClass]
    public class PruebaHospitales
    {

        [TestMethod]
        public void Insertar()
        {
            Entidades.Hospital hospital = new Entidades.Hospital();

            hospital.Nombre = "Alvear";

            Negocio.Hospital.Grabar(hospital);

        }


        [TestMethod]

        public void Obtener()
        {
            Negocio.Hospital.Obtener(1);
        }


        [TestMethod]

        public void Listar()
        {
            Negocio.Hospital.Listar();
        }



        [TestMethod]
        public void Modificar()
        {
            Entidades.Hospital hospital = new Entidades.Hospital();

            hospital.IdHospital = 1;

            hospital.Nombre = "Durand";

            Negocio.Hospital.Modificar(hospital);


        }


        //[TestMethod]
        //public void Eliminar()
        //{
        //    Negocio.Hospital.Eliminar(1);
        //}




    }
}
