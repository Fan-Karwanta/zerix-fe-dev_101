using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace zerix_fe_dev.Pages;

public class ArchivePage : PageModel
{
    private readonly ILogger<ArchivePage> _logger;

    public ArchivePage(ILogger<ArchivePage> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
