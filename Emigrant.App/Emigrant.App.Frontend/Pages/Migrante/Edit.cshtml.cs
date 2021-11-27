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
    public class EditMigranteModel : PageModel
    {
        private readonly RepositorioMigrante repositorioMigrante;
        [BindProperty]
        public Migrante Migrante {get;set;}
 
        public EditMigranteModel(RepositorioMigrante repositorioMigrante)
        {
            this.repositorioMigrante=repositorioMigrante;
        }
 
        public IActionResult OnGet(int migranteId)
        {
            Migrante=repositorioMigrante.GetMigranteWithId(migranteId);
            return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Migrante.id>0)
            {
                Migrante = repositorioMigrante.Update(Migrante);
            }
            return RedirectToPage("./List");
        }



    }
}
