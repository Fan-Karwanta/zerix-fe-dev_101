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
                Title = "Holiday - Brgy. Election",
                Content = "Good day!\n\nThis is a reminder to please check your DTR and submit any relevant forms by visiting https://ess.optimum-source.com/#/login\n\nPlease make sure to remind your approvers of any pending applications, and check the status of any submitted forms.\n\nApprovers must check and approve all filings of your team daily.\n\nFor those who worked last May 12, 2025 (National Election) kindly file it as OVERTIME\n\nPayroll Coverage: May 6, 2025 to May 20, 2025\n\nCutoff for Morning shift and Mid Shift: May 20, 2025 (until 11 PM)\n\nCutoff for Graveyard shift/Night Shift: May 21, 2025 (until 12 PM ONLY)\n\nTo those who had a salary dispute last May 10th payroll, kindly submit any missing clock-in or clock-out records, overtime requests, OB requests, and change shift requests. Please advise your manager or immediate supervisor to approve them.",
                Date = new DateTime(2023, 10, 29),
                Author = "Admin",
                Priority = "urgent",
                IconPath = "/images/icons/urgent.png"
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
