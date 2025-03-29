namespace TourCore.Models.ViewModels
{
    public class PaymentInfoViewModel
    {
        public bool Success { get; set; }
        public string Amount { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public string PaymentContent { get; set; }
        public string QrContent { get; set; }
    }
}