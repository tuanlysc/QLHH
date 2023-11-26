using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace QLHS.Models.MetaData
{
    public class WareHouseMetaData
    {
        [DisplayName("Mã kho")]
        public int id { get; set; }
        [DisplayName("Số lượng")]
        public int quantity { get; set; }
        [DisplayName("Mã sách")]
        public Nullable<int> book_id { get; set; }
        [DisplayName("Sách")]
        public virtual book book { get; set; }
    }
}