
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class WebClientsPage : PageModel
{
    private readonly ILogger<WebClientsPage> _logger;

    public WebClientsPage(ILogger<WebClientsPage> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
