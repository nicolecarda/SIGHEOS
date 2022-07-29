using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasSIGHEOS
{
    [TestClass]
    public class PruebaEvoluciones
    {

        [TestMethod]
        public void Insertar()
        {
            Entidades.Evolucion evolucion = new Entidades.Evolucion();
            
            evolucion.Profesional = Negocio.Profesional.Obtener(7);
            evolucion.HistoriaClinica = Negocio.HistoriaClinica.Obtener(3);
            evolucion.Fecha = DateTime.Now;
            evolucion.Descripcion = "La pcte. presenta una masa extraña en el pulmon, se realiza estudio y punsión";

            Negocio.Evolucion.Grabar(evolucion);

        }


        [TestMethod]

        public void Obtener()
        {
            Negocio.Evolucion.Obtener(5);
        }


        [TestMethod]

        public void Listar()
        {
            Negocio.Evolucion.Listar();
        }



        [TestMethod]
        public void Modificar()
        {
            Entidades.Evolucion evolucion = new Entidades.Evolucion();

            evolucion.IdEvolucion = 1;
            evolucion.Profesional = Negocio.Profesional.Obtener(7);
            evolucion.HistoriaClinica = Negocio.HistoriaClinica.Obtener(4);
            evolucion.Fecha = DateTime.Now;
            evolucion.Descripcion = "La pcte. presenta una masa extraña en el pulmon, se realiza estudio y punsión, la anatomía patológica dió negativa, se prescribe medicación";

            Negocio.Evolucion.Modificar(evolucion);


        }


        //[TestMethod]
        //public void Eliminar()
        //{
        //    Negocio.Evolucion.Eliminar(3);
        //}





    }
}
