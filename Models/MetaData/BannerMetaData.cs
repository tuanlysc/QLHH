using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace QLHS.Models.MetaData
{
    public class BannerMetaData
    {
        [DisplayName("STT")]
        public int id { get; set; }
        [DisplayName("Ảnh banner")]
        public string img { get; set; }
        [DisplayName("Link Banner")]
        public string link { get; set; }
        [DisplayName("Địa chỉ")]
        public int position { get; set; }
        [DisplayName("Trạng thái")]
        public Nullable<bool> status { get; set; }
    }
}