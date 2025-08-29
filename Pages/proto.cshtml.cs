using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class ProtoModel : PageModel
{
    private readonly ILogger<ProtoModel> _logger;

    public ProtoModel(ILogger<ProtoModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

