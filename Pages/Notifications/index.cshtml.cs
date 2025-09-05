using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class Notification
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Author { get; set; } = string.Empty;
    public string Priority { get; set; } = string.Empty;
    public string IconPath { get; set; } = string.Empty;
}

public class NotificationsIndexModel : PageModel
{
    private readonly ILogger<NotificationsIndexModel> _logger;

    public List<Notification> Notifications { get; set; } = new();

    public NotificationsIndexModel(ILogger<NotificationsIndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        // Sample notification data
        Notifications = new List<Notification>
        {
            new Notification
            {
                Id = 1,
                Title = "Holiday - Bug: Election",
                Content = "Please be informed that there will be a holiday on election day. All offices will be closed and operations will resume the following business day.",
                Date = new DateTime(2023, 10, 25),
                Author = "Admin",
                Priority = "urgent",
                IconPath = "https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.0/icons/exclamation-triangle-fill.svg"
            },
            new Notification
            {
                Id = 2,
                Title = "Internet Access Interruption",
                Content = "Please be informed that you will experience slow internet access connection due to repair and ongoing maintenance being conducted today. We apologize for any inconvenience this may cause.",
                Date = new DateTime(2023, 10, 25),
                Author = "IT",
                Priority = "normal",
                IconPath = ""
            },
            new Notification
            {
                Id = 3,
                Title = "Payment",
                Content = "Monthly payment reminder for your subscription. Please ensure your payment method is up to date to avoid service interruption.",
                Date = new DateTime(2023, 10, 13),
                Author = "PILOT",
                Priority = "normal",
                IconPath = ""
            }
        };
    }
}
