using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace zerix_fe_dev.Pages;

public class ImportContactsPage : PageModel
{
    private readonly ILogger<ImportContactsPage> _logger;

    public ImportContactsPage(ILogger<ImportContactsPage> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
