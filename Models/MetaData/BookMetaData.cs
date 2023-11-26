using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace QLHS.Models.MetaData
{
    internal class BookMetaData
    {
        [DisplayName("STT")]
        public int id { get; set; }
        [DisplayName("Tên sách")]
        [Required(ErrorMessage = "Tên bắt buộc phải nhập")]
        public string book_name { get; set; }
        public string description { get; set; }
        [DisplayName("Ảnh sản phẩm")]
        public string image { get; set; }
        [DisplayName("Giá")]
        [Required(ErrorMessage = "Đơn giá bắt buộc phải nhập")]
        public long price { get; set; }
        [DisplayName("Giá nhập")]
        public long price_enter { get; set; }
        [DisplayName("Giá sale")]
        public long price_sale { get; set; }
        [DisplayName("Lợi nhuận")]
        public Nullable<int> profit { get; set; }
        [DisplayName("Năm phát hành")]
        public Nullable<int> publication_year { get; set; }
        [DisplayName("Giảm giá")]
        public Nullable<int> sale { get; set; }
        [DisplayName("Đánh giá")]
        public Nullable<double> star { get; set; }
        [DisplayName("Trạng thái")]
        public Nullable<bool> status { get; set; }
        [DisplayName("Tác giả")]
        public Nullable<int> author_id { get; set; }
        [DisplayName("Danh mục")]
        public Nullable<int> category_id { get; set; }
        [DisplayName("Nhà xuất bản")]
        public Nullable<int> publicsher_id { get; set; }
    }
}