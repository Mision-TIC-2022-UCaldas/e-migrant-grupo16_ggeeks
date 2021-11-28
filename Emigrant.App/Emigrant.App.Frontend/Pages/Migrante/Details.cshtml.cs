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
    public class DetailsMigranteModel : PageModel
    {
       private readonly RepositorioMigrante repositorioMigrantes;
        public Migrante Migrante {get;set;}
 
        public DetailsMigranteModel(RepositorioMigrante repositorioMigrantes)
        {
            this.repositorioMigrantes=repositorioMigrantes;
        }
 
        public IActionResult OnGet(int migranteId)
        {
            Migrante=repositorioMigrantes.GetMigranteWithId(migranteId);
            return Page();
        }
    }
}
