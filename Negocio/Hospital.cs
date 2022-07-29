using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class Hospital
    {
            #region Metodos publicos

            public static List<Entidades.Hospital> Listar()
            {

                DataTable dt = new DataTable();
                dt = Datos.Hospitales.Listar();

                List<Entidades.Hospital> listaHospitales = new List<Entidades.Hospital>();

                foreach (DataRow item in dt.Rows)
                {
                    listaHospitales.Add(ArmarDatos(item));
                }


                return listaHospitales;
            }

            public static void Eliminar(int idHospital)
            {
                Datos.Hospitales.Eliminar(idHospital);
            }

            public static int Grabar(Entidades.Hospital Hospital)
            {
                try
                {
                    if (Validar(Hospital, out string error))
                    {
                        if (Hospital.IdHospital == null)
                        {
                            return Insertar(Hospital);
                        }
                        else
                        {
                            return Modificar(Hospital);
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

            public static Entidades.Hospital Obtener(int idHospital)
            {
                DataTable dt = new DataTable();
                dt = Datos.Hospitales.Obtener(idHospital);

                return ArmarDatos(dt.Rows[0]);
            }


            public static int Modificar(Entidades.Hospital Hospital)
            {
                Datos.Hospitales.Modificar(Hospital);

                return Hospital.IdHospital.Value;
            }

            #endregion

            #region Metodos privados

            private static int Insertar(Entidades.Hospital Hospital)
                {
                    return Datos.Hospitales.Insertar(Hospital);
                }

            

            private static bool Validar(Entidades.Hospital hospital, out string error)
            {
                error = "";

               
                if (string.IsNullOrEmpty(hospital.Nombre))
                    error += "No se ha ingresado el nombre del hospital";

                if (string.IsNullOrEmpty(error))
                    return true;
                else
                    return false;
            }

            private static Entidades.Hospital ArmarDatos(DataRow item)
            {
                Entidades.Hospital Hospital = new Entidades.Hospital();

                Hospital.IdHospital = Convert.ToInt32(item["IdHospital"]);
                Hospital.Nombre = item["Nombre"].ToString();

            return Hospital;
            }

            #endregion




        }
    }
