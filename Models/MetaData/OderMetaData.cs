using System.ComponentModel;
using System;

namespace QLHS.Models.MetaData
{
    internal class OderMetaData
    {
        [DisplayName("STT")]
        public int id { get; set; }
        [DisplayName("Địa chỉ")]
        public string address_ship { get; set; }
        [DisplayName("Thời gian tạo đơn")]
        public Nullable<System.DateTime> date_order { get; set; }
        [DisplayName("Tên đơn")]
        public string full_name { get; set; }
        [DisplayName("Ghi chú")]
        public string note { get; set; }
        [DisplayName("SDT")]
        public string phone { get; set; }
        [DisplayName("Trạng thái")]
        public Nullable<int> status { get; set; }
        [DisplayName("Tổng tiền")]
        public long sum_money { get; set; }
        [DisplayName("")]
        public Nullable<long> user_id { get; set; }
    }
}