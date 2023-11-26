using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace QLHS.Models.MetaData
{
    public class AuthorMetaData
    {
        [DisplayName("STT")]
        public int id { get; set; }
        [DisplayName("Ảnh")]
        public string img { get; set; }
        [DisplayName("Tên tác giả")]
        public string name_author { get; set; }
    }
}