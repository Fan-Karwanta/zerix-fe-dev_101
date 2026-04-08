
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class SystemConfigModel : PageModel
{
    private readonly ILogger<SystemConfigModel> _logger;

    public SystemConfigModel(ILogger<SystemConfigModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
