using EcoBiteBookWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

public class DashboardController : Controller
{
    public IActionResult Index()
    {
        var model = new DashboardViewModel
        {
            TotalDonations = 150,
            TotalReceivers = 75,
            TotalVolunteers = 20,
            ActiveDeliveries = 5,
            PendingRequests = 10,
            EnvironmentalImpact = "300kg Waste Reduced"
        };

        return View(model);
    }
}
