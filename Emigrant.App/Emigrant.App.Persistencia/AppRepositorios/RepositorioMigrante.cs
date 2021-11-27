using System.Collections.Generic;
using Emigrant.App.Dominio;
using System.Linq;
using System;
 
namespace Emigrant.App.Persistencia.AppRepositorios
{
    public class RepositorioMigrante
    {
        List<Migrante> migrantes;
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
 
        public IEnumerable<Migrante> GetAll()
        {
            //return migrantes;
            return _appContext.Migrantes;
        }
 
        public Migrante GetMigranteWithId(int id){
            //return migrantes.SingleOrDefault(b => b.id == id);
            return _appContext.Migrantes.Find(id);
        }

        public Migrante Update(Migrante newMigrante){
            //var migrant= migrantes.SingleOrDefault(b => b.id == newMigrante.id);
            var migrant = _appContext.Migrantes.Find(newMigrante.id);
            if(migrant != null){
                migrant.nombre = newMigrante.nombre;
                migrant.apellidos = newMigrante.apellidos;
                migrant.tipodocumento = newMigrante.tipodocumento;
                migrant.numeroidentificacion = newMigrante.numeroidentificacion;
                migrant.paisorigen = newMigrante.paisorigen;
                migrant.fechanacimiento = newMigrante.fechanacimiento;
                migrant.email = newMigrante.email;
                migrant.telefono = newMigrante.telefono;
                migrant.direccionactual = newMigrante.direccionactual;
                migrant.ciudad = newMigrante.ciudad;
                migrant.situacionlaboral = newMigrante.situacionlaboral;
                _appContext.SaveChanges(); // Guarda en BD
            }
            return migrant;
        }

        public Migrante Create(Migrante newMigrante)
        {
            var addMigrante = _appContext.Migrantes.Add(newMigrante);
            _appContext.SaveChanges();
            return addMigrante.Entity;
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
            var migrant = _appContext.Migrantes.Find(id);
            if (migrant == null)
                return;
            _appContext.Migrantes.Remove(migrant);
            _appContext.SaveChanges();
        }



    }
}
