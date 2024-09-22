using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

[Authorize]
public class ModelDeJoc : PageModel
{
    private readonly ILogger<ModelDeJoc> _logger;

    public ModelDeJoc(ILogger<ModelDeJoc> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

