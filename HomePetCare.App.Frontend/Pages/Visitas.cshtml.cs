using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomePetCare.App.Frontend.Pages;

public class VisitasModel : PageModel
{
    private readonly ILogger<VisitasModel> _logger;

    public VisitasModel(ILogger<VisitasModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

