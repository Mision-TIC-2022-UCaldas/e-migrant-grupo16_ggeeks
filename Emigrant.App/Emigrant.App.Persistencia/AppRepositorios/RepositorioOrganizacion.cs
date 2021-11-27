using System.Collections.Generic;
using Emigrant.App.Dominio;
using System.Linq;
using System;
 
namespace Emigrant.App.Persistencia.AppRepositorios
{
    public class RepositorioOrganizacion
    {
        List<Organizacion> organizacion;
        private readonly AppContext _appContext = new AppContext(); //Objeto para conectar con Base de Datos
 
        /*public RepositorioMigrante()
        {
            migrantes= new List<Migrante>()
            {
                new Migrante{id=1,nombre="Audi"},
                new Migrante{id=2,nombre="Toyota"},
                new Migrante{id=3,nombre="Mazda"}
 
            };
        }*/
 
        public IEnumerable<Organizacion> GetAll()
        {
            //return migrantes;
            return _appContext.Organizacion;
        }
 
        public Organizacion GetOrganizacionWithId(int id){
            //return migrantes.SingleOrDefault(b => b.id == id);
            return _appContext.Organizacion.Find(id);
        }

        public Organizacion Update(Organizacion newOrganizacion){
            //var migrant= migrantes.SingleOrDefault(b => b.id == newMigrante.id);
            var organz = _appContext.Organizacion.Find(newOrganizacion.id);
            if(organz != null){
                organz.razonsocial = newOrganizacion.razonsocial;
                organz.nit = newOrganizacion.nit;
                organz.direccion = newOrganizacion.direccion;
                organz.ciudad = newOrganizacion.ciudad;
                organz.telefono = newOrganizacion.telefono;
                organz.correo = newOrganizacion.correo;
                organz.paginaweb = newOrganizacion.paginaweb;
                organz.sector = newOrganizacion.sector;
                organz.servicioofrece = newOrganizacion.servicioofrece;
                _appContext.SaveChanges(); // Guarda en BD
            }
            return organz;
        }

        public Organizacion Create(Organizacion newOrganizacion)
        {
            var addOrganizacion = _appContext.Organizacion.Add(newOrganizacion);
            _appContext.SaveChanges();
            return addOrganizacion.Entity;
            /*if(migrantes.Count > 0){
                newMigrante.id=migrantes.Max(r => r.id) +1; 
            }else{
               newMigrante.id = 1; 
            }
            migrantes.Add(newMigrante);
            return newMigrante;*/
        }

        //public Migrante Delete(int id)
        public void Delete(int id)
        {
            /*var migrant= migrantes.SingleOrDefault(b => b.id == id);
            migrantes.Remove(migrant);
            return migrant;*/
            var organz = _appContext.Organizacion.Find(id);
            if (organz == null)
                return;
            _appContext.Organizacion.Remove(organz);
            _appContext.SaveChanges();
        }



    }
}
