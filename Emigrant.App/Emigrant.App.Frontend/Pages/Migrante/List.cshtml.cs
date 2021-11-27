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
    public class ListMigranteModel : PageModel
    {

        private readonly RepositorioMigrante repositorioMigrante;
        public IEnumerable<Migrante> Migrante {get;set;}
        [BindProperty]
        public Migrante Migrante1 {get;set;}

        public ListMigranteModel(RepositorioMigrante repositorioMigrante)
        {
            this.repositorioMigrante=repositorioMigrante;
        }

        public void OnGet()
        {
            Migrante=repositorioMigrante.GetAll();
        }

        public IActionResult OnPost()
        {
            if(Migrante1.id>0)
            {
                //Migrante1 = repositorioMigrante.Delete(Migrante1.id);
                repositorioMigrante.Delete(Migrante1.id);
            }
            return RedirectToPage("./List");
        }

    }
}
