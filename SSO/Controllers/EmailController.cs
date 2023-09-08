//using Microsoft.AspNetCore.Mvc;
//using SSO.Services;

//namespace SSO.Controllers;

//public class EmailController : Controller
//{
//    private readonly OutlookService _outlookService;

//    public EmailController(OutlookService outlookService)
//    {
//        _outlookService = outlookService;
//    }

//    public async Task<IActionResult> Index()
//    {
//        var emails = await _outlookService.GetEmailsAsync();
//        // Process and display emails as needed
//        return View(emails);
//    }
//}
