using System;
using Microsoft.AspNetCore.Mvc;
using TourCore.Models.Commands;
using TourCore.Services;

namespace TourCore.Controllers
{
    public class BookingTourController : Controller
    {
        private readonly BookingService _bookingService;
        private readonly TourService _tourService;

        public BookingTourController(TourService tourService, BookingService bookingService)
        {
            _bookingService = bookingService;
            _tourService = tourService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BookingTour(BookingTourCommand command)
        {
            if (!ModelState.IsValid)
            {
                var model = _tourService.TourDetail(command.TourId);
                return View("/Views/Tour/TourDetail.cshtml", model);
            }

            try
            {




                // Gọi service để xử lý đặt tour
                _bookingService.BookingTour(command);

                // Trả về phản hồi đơn giản
                return Json(new { success = true, message = "Đặt tour thành công" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}