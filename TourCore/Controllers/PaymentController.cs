using Microsoft.AspNetCore.Mvc;
using TourCore.Models.ViewModels;

namespace TourCore.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Checkout()
        {
            var paymentInfo = TempData["PaymentInfo"] as PaymentInfoViewModel;
            if (paymentInfo == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(paymentInfo);
        }
    }
}