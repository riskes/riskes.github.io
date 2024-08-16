using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

[Authorize]
public class VideoModel : PageModel
{
    private readonly ILogger<VideoModel> _logger;

    public VideoModel(ILogger<VideoModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

