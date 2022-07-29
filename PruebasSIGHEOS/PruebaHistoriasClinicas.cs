using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebasSIGHEOS
{
    [TestClass]
    public class PruebaHistoriasClinicas
    {
        [TestMethod]
        public void Insertar()
        {
            Entidades.HistoriaClinica historiaClinica = new Entidades.HistoriaClinica();
           
            historiaClinica.NombreLegalPac = "Nicole";
            historiaClinica.NombreAutopercibidoPac = "Nicole";
            historiaClinica.ApellidoPac = "Carda";
            historiaClinica.EdadPac = 26;
            historiaClinica.FechaNacimientoPac = DateTime.Now;            
            historiaClinica.SexoPac = false; //false = F ; True = M
            historiaClinica.DNIPac = 39469889;
            historiaClinica.DomicilioPac = "Pareja 3377";
            historiaClinica.TelefonoPac = 23456789;
            historiaClinica.ObraSocialPac = false; //true = Tiene obra social; false = No tiene obra social
            
            Negocio.HistoriaClinica.Grabar(historiaClinica);

        }

        
        [TestMethod]

        public void Obtener()
        {
            Negocio.HistoriaClinica.Obtener(2);
        }


        [TestMethod]

        public void Listar()
        {
            Negocio.HistoriaClinica.Listar();
        }



        [TestMethod]
        public void Modificar()
        {
            Entidades.HistoriaClinica historiaClinica = new Entidades.HistoriaClinica();

            historiaClinica.NroHC = 2;
            historiaClinica.NombreLegalPac = "Nicole";
            historiaClinica.NombreAutopercibidoPac = "Pepe";
            historiaClinica.ApellidoPac = "Carda";
            historiaClinica.EdadPac = 28;
            historiaClinica.FechaNacimientoPac = DateTime.Now;           
            historiaClinica.SexoPac = true; //false = F ; True = M
            historiaClinica.DNIPac = 39469889;
            historiaClinica.DomicilioPac = "Pareja 3377";
            historiaClinica.TelefonoPac = 23456789;
            historiaClinica.ObraSocialPac = false; //true = Tiene obra social; false = No tiene obra social

            Negocio.HistoriaClinica.Modificar(historiaClinica);


        }


        //[TestMethod]
        //public void Eliminar()
        //{
        //    Negocio.HistoriaClinica.Eliminar(2);
        //}



    }
}
