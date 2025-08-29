
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class SwitchOrgModel : PageModel
{
    private readonly ILogger<SwitchOrgModel> _logger;

    public SwitchOrgModel(ILogger<SwitchOrgModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
