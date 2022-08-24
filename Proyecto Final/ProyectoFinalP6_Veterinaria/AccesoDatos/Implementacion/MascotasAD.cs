using AccesoDatos.Interfaces;//AGREGAR
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementacion
{
    public class MascotasAD : IMascotas
    {
        private VeterEntidades gObjConexionAW;

        public MascotasAD(VeterEntidades lObjConexion)  //CONSTRUCTOR
        {
            gObjConexionAW = lObjConexion;
        }

        ///////****ENTIDADES****/////
        public List<Mascotas> recMascotas_ENT()
        {
            //VARIABLE
            List<Mascotas> lobjRespuesta = new List<Mascotas>();
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionAW.Mascotas.ToList();
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

        public Mascotas recMascotasXId_ENT(int pId)
        {
            //VARIABLE
            Mascotas lobjRespuesta = new Mascotas();
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionAW.Mascotas.ToList().Find(cl => cl.IDMascota == pId);
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

        public bool insMascotas_ENT(Mascotas pMascota)
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionAW.Clientes.Find(pMascota.IDMascota);
                if (regEncontrado == null)
                {
                    gObjConexionAW.Mascotas.Add(pMascota);
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

        public bool modMascotas_ENT(Mascotas pMascota)
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionAW.Mascotas.Find(pMascota.IDMascota);
                if (regEncontrado != null)
                {
                    gObjConexionAW.Entry(regEncontrado).CurrentValues.SetValues(pMascota);
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

        public bool delMascotas_ENT(Mascotas pMascota) // O SOLO PODRIAMOS USAR EL ID 
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionAW.Mascotas.Find(pMascota.IDMascota);
                if (regEncontrado != null)
                {
                    gObjConexionAW.Entry(regEncontrado).CurrentValues.SetValues(pMascota);
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
