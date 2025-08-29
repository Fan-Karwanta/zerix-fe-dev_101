using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace zerix_fe_dev.Pages;

public class ContactGroupsModel : PageModel
{
    private readonly ILogger<ContactGroupsModel> _logger;

    public ContactGroupsModel(ILogger<ContactGroupsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
