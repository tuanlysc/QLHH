using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace QLHS.Models.MetaData
{
    public class PublicsherMetaData
    {
        [DisplayName("Id")]
        public int id { get; set; }
        [DisplayName("Nhà xuất bản")]
        public string name_publicsher { get; set; }
    }
}