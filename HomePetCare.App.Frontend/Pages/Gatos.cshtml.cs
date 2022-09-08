using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomePetCare.App.Frontend.Pages;

public class GatosModel : PageModel
{
    private readonly ILogger<GatosModel> _logger;

    public GatosModel(ILogger<GatosModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

