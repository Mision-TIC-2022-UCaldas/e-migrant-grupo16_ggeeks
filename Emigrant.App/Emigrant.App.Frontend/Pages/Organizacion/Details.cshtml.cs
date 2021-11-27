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
    public class DetailsOrganizacionModel : PageModel
    {
       private readonly RepositorioOrganizacion repositorioOrganizacion;
        public Organizacion Organizacion {get;set;}
 
        public DetailsOrganizacionModel(RepositorioOrganizacion repositorioOrganizacion)
        {
            this.repositorioOrganizacion=repositorioOrganizacion;
        }
 
        public IActionResult OnGet(int organizacionId)
        {
            Organizacion=repositorioOrganizacion.GetOrganizacionWithId(organizacionId);
            return Page();
        }
    }
}