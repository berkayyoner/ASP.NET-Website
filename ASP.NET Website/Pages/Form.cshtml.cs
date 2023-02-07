using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_Website.Pages
{
    public class FormModel : PageModel
    {
        private readonly ILogger<FormModel> logger;
        public FormModel(ILogger<FormModel> logger)
        {
            this.logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
