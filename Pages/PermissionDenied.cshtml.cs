using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class PermissionDeniedModel : PageModel
{
    private readonly ILogger<PermissionDeniedModel> _logger;

    public PermissionDeniedModel(ILogger<PermissionDeniedModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

