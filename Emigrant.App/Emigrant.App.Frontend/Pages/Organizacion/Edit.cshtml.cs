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
    public class EditOrganizacionModel : PageModel
    {
        private readonly RepositorioOrganizacion repositorioOrganizacion;
        [BindProperty]
        public Organizacion Organizacion {get;set;}
 
        public EditOrganizacionModel(RepositorioOrganizacion repositorioOrganizacion)
        {
            this.repositorioOrganizacion=repositorioOrganizacion;
        }
 
        public IActionResult OnGet(int organizacionId)
        {
            Organizacion=repositorioOrganizacion.GetOrganizacionWithId(organizacionId);
            return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Organizacion.id>0)
            {
                Organizacion = repositorioOrganizacion.Update(Organizacion);
            }
            return RedirectToPage("./List");
        }



    }
}
