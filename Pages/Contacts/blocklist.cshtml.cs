using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace zerix_fe_dev.Pages;

public class BlocklistContactModel : PageModel
{
    private readonly ILogger<BlocklistContactModel> _logger;

    public BlocklistContactModel(ILogger<BlocklistContactModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
