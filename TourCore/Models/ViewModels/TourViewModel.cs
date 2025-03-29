using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TourCore.Models.Db;

namespace TourCore.Models.ViewModels
{
    public class TourViewModel
    {
        public int Id { get; set; }

        [DisplayName("Mã Tour")]
        public string Code { get; set; }

        [DisplayName("Tên Tour")]
        public string NameTour { get; set; }

        [DisplayName("Ngày")]
        public int? Day { get; set; }

        [DisplayName("Đêm")]
        public int? Night { get; set; }

        [DisplayName("Giá Tiền")]
        public decimal? Cost { get; set; }

        [DisplayName("Hình ảnh")]
        public string Picture { get; set; }

        [DisplayName("Tour Nổi Bật")]
        public bool TopHot { get; set; }

        [DisplayName("Tour Mới")]
        public bool NewTour { get; set; }

        [DisplayName("Giảm Giá")]
        public decimal? Discount { get; set; }

        [DisplayName("Số Lượng Đặt")]
        public int NumberBooking { get; set; }

        [DisplayName("Mô Tả")]
        public string Description { get; set; }

        [DisplayName("Trong Nước")]
        public bool Domestic { get; set; }

        [DisplayName("Quốc Tế")]
        public bool National { get; set; }

        [DisplayName("Số Lượng")]
        public int? Quantity { get; set; }

        [DisplayName("Tiêu Đề")]
        public string Title { get; set; }
    }
}