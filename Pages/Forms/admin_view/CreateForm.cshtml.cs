using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages.Forms.admin_view;

public class CreateFormModel : PageModel
{
    private readonly ILogger<CreateFormModel> _logger;

    public CreateFormModel(ILogger<CreateFormModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
