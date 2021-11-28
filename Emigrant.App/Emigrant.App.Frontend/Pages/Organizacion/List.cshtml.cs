using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Emigrant.App.Persistencia.AppRepositorios;
using Emigrant.App.Dominio;
 
namespace Emigrant.App.Frontend.Pages
{
    public class ListOrganizacionModel : PageModel
    {

        private readonly RepositorioOrganizacion repositorioOrganizacion;
        public IEnumerable<Organizacion> Organizacion {get;set;}
        [BindProperty]
        public Organizacion Organizacion1 {get;set;}

        public ListOrganizacionModel(RepositorioOrganizacion repositorioOrganizacion)
        {
            this.repositorioOrganizacion=repositorioOrganizacion;
        }

        public void OnGet()
        {
            Organizacion=repositorioOrganizacion.GetAll();
        }

        public IActionResult OnPost()
        {
            if(Organizacion1.id>0)
            {
                //Migrante1 = repositorioMigrante.Delete(Migrante1.id);
                repositorioOrganizacion.Delete(Organizacion1.id);
            }
            return RedirectToPage("./List");
        }

    }
}
