using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public List<IFormFile> UploadedFiles { get; set; } = new List<IFormFile>();

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public IActionResult OnPostUploadFiles(List<IFormFile> files)
    {
        if (files != null && files.Count > 0)
        {
            foreach (var file in files)
            {
                UploadedFiles.Add(file);
            }
        }

        // Redirect to Get request to reset form state
        return RedirectToPage();
    }
}
