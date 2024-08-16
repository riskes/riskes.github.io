using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

[Authorize]
public class GestioGrupal : PageModel
{
    private readonly ILogger<GestioGrupal> _logger;

    public GestioGrupal(ILogger<GestioGrupal> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

