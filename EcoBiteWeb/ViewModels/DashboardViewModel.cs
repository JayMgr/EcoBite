namespace EcoBiteBookWeb.ViewModels
{
    public class DashboardViewModel
    {
        public int TotalDonations { get; set; }
        public int TotalReceivers { get; set; }
        public int TotalVolunteers { get; set; }
        public int ActiveDeliveries { get; set; }
        public int PendingRequests { get; set; }
        public string EnvironmentalImpact { get; set; }
    }

}
