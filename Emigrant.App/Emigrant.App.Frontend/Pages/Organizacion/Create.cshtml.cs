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
    public class FormOrganizacionModel : PageModel
    {

        private readonly RepositorioOrganizacion repositorioOrganizacion;
        [BindProperty]
        public Organizacion Organizacion {get;set;}

        public FormOrganizacionModel(RepositorioOrganizacion repositorioOrganizacion)
        {
            this.repositorioOrganizacion=repositorioOrganizacion;
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
            Organizacion = repositorioOrganizacion.Create(Organizacion);            
            return RedirectToPage("./List");
        }

    }
}
