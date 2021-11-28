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
    public class FormMigranteModel : PageModel
    {

        private readonly RepositorioMigrante repositorioMigrantes;
        [BindProperty]
        public Migrante Migrante {get;set;}

        public FormMigranteModel(RepositorioMigrante repositorioMigrantes)
        {
            this.repositorioMigrantes=repositorioMigrantes;
        }

        public void OnGet()
        {
 
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }            
            Migrante = repositorioMigrantes.Create(Migrante);            
            return RedirectToPage("./List");
        }

    }
}
