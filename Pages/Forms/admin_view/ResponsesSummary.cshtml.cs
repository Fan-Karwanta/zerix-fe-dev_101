using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages.Forms.admin_view;

public class ResponsesSummaryModel : PageModel
{
    private readonly ILogger<ResponsesSummaryModel> _logger;

    public ResponsesSummaryModel(ILogger<ResponsesSummaryModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
