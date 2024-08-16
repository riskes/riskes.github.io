using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

[Authorize]
public class JugadesModel : PageModel
{
    private readonly ILogger<JugadesModel> _logger;

    public JugadesModel(ILogger<JugadesModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

