using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

[Authorize]
public class SistemaDefensiu : PageModel
{
    private readonly ILogger<SistemaDefensiu> _logger;

    public SistemaDefensiu(ILogger<SistemaDefensiu> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

