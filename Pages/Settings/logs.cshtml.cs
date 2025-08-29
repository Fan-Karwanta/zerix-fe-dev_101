

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class LogsPage : PageModel
{
    private readonly ILogger<LogsPage> _logger;

    public LogsPage(ILogger<LogsPage> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
