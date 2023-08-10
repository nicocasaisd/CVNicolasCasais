using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CVNicolasCasais.Pages
{
    public class ContactoModel : PageModel
    {
        public bool enviado = false;

        public void OnGet()
        {
        }

        public void OnPost()
        {
            enviado = true;
        }
    }
}
