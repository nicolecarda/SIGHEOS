using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasSIGHEOS
{
    [TestClass]
    public class PruebaProfesionales
    {

        [TestMethod]
        public void Insertar()
        {
            Entidades.Profesional profesional = new Entidades.Profesional();
           
            profesional.Nombre = "Natalia";
            profesional.Apellido = "Rodriguez";
            profesional.Especialidad = "Neumonología";
            profesional.Hospital = Entidades.Enumerables.Hospitales.Alvear;
            profesional.Email = "NR98@gmail.com";
            profesional.Clave = "1234";
            profesional.CodigoActivacion = "2870AB";
            profesional.Activo = true;

            Negocio.Profesional.Grabar(profesional);

        }


        [TestMethod]

        public void Obtener()
        {
            Negocio.Profesional.Obtener(7);
        }


        [TestMethod]

        public void Listar()
        {
            Negocio.Profesional.Listar();
        }



        [TestMethod]
        public void Modificar()
        {
            Entidades.Profesional profesional = new Entidades.Profesional();

            profesional.IdProfesional = 7;
            profesional.Nombre = "Natalia";
            profesional.Apellido = "Rodriguez";
            profesional.Especialidad = "Neumonología";
            profesional.Hospital = Entidades.Enumerables.Hospitales.Alvear;
            profesional.Email = "NR98@gmail.com";
            profesional.Clave = "1234";
            profesional.CodigoActivacion = "2870AB";
            profesional.Activo = true;
            
            Negocio.Profesional.Modificar(profesional);


        }


        //[TestMethod]
        //public void Eliminar()
        //{
        //    Negocio.Profesional.Eliminar(7);
        //}



    }
}




 