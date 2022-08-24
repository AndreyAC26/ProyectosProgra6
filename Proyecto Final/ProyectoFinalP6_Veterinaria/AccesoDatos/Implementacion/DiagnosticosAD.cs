using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Interfaces;//AGREGAR
using Entidades; //AGREGAR

namespace AccesoDatos.Implementacion
{
    public class DiagnosticosAD : IDiagnosticos
    {
        private VeterEntidades gObjConexionAW;

        public DiagnosticosAD(VeterEntidades lObjConexion)  //CONSTRUCTOR
        {
            gObjConexionAW = lObjConexion;
        }

        ///////****ENTIDADES****/////
        public List<Diagnósticos> recDiagnosticos_ENT()
        {
            //VARIABLE
            List<Diagnósticos> lobjRespuesta = new List<Diagnósticos>();
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionAW.Diagnósticos.ToList();
            }
            catch (Exception lEx)
            { 

                throw lEx;
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public Diagnósticos recDiagnosticosXId_ENT(int pId)
        {
            //VARIABLE
            Diagnósticos lobjRespuesta = new Diagnósticos();
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionAW.Diagnósticos.ToList().Find(cl => cl.IDDiagnostico == pId);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool insDiagnosticos_ENT(Diagnósticos pDiagnostico)
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionAW.Clientes.Find(pDiagnostico.IDDiagnostico);
                if (regEncontrado == null)
                {
                    gObjConexionAW.Diagnósticos.Add(pDiagnostico);
                    // gObjConexionAW.Entry(regEncontrado).State = System.Data.Entity.EntityState.Added; // SEGUNDA OPCION
                    gObjConexionAW.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool modDiagnosticos_ENT(Diagnósticos pDiagnostico)
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionAW.Diagnósticos.Find(pDiagnostico.IDDiagnostico);
                if (regEncontrado != null)
                {
                    gObjConexionAW.Entry(regEncontrado).CurrentValues.SetValues(pDiagnostico);
                    gObjConexionAW.Entry(regEncontrado).State = System.Data.Entity.EntityState.Modified;
                    gObjConexionAW.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool delDiagnosticos_ENT(Diagnósticos pDiagnostico) // O SOLO PODRIAMOS USAR EL ID 
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionAW.Diagnósticos.Find(pDiagnostico.IDDiagnostico);
                if (regEncontrado != null)
                {
                    gObjConexionAW.Entry(regEncontrado).CurrentValues.SetValues(pDiagnostico);
                    gObjConexionAW.Entry(regEncontrado).State = System.Data.Entity.EntityState.Deleted;
                    gObjConexionAW.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }
    }
}
