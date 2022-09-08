using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomePetCare.App.Frontend.Pages;

public class ContacoModel : PageModel
{
    private readonly ILogger<ContacoModel> _logger;

    public ContacoModel(ILogger<ContacoModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

