using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomePetCare.App.Frontend.Pages;

public class GaleriaModel : PageModel
{
    private readonly ILogger<GaleriaModel> _logger;

    public GaleriaModel(ILogger<GaleriaModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

