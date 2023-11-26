using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLHS.Models.MetaData
{
    public class UserMetaData
    {
        [DisplayName("Tài khoản")]
        [Required(ErrorMessage ="Tài khoản không được để trống")]
        public string user_name { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [MinLength(4,ErrorMessage ="Mật khẩu không được ngắn hơn 4 kí tự")]
        public string pass_word { get; set; }
    }
}