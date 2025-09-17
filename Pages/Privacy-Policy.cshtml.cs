using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class PrivacyPolicyStandaloneModel : PageModel
{
    private readonly ILogger<PrivacyPolicyStandaloneModel> _logger;

    public PrivacyPolicyStandaloneModel(ILogger<PrivacyPolicyStandaloneModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
