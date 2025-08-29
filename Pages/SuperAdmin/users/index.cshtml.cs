
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class UserPage : PageModel
{
    private readonly ILogger<UserPage> _logger;

    public UserPage(ILogger<UserPage> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
