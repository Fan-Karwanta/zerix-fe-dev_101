
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class UserGroupsPage : PageModel
{
    private readonly ILogger<UserGroupsPage> _logger;

    public UserGroupsPage(ILogger<UserGroupsPage> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
