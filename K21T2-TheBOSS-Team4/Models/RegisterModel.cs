using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace K21T2_TheBOSS_Team4.Models
{
    public class RegisterModel
    {
        [Key]
        public long ID { set; get; }

        [Display(Name="Nhập địa chỉ Email")]
        [Required(ErrorMessage ="Yêu cầu nhập tên đăng nhập")]
        public string Email { set; get; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        [StringLength(30,MinimumLength = 8, ErrorMessage ="Phải nhập ít nhất 8 ký tự")]
        public string Password { set; get; }

        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("Password",ErrorMessage ="Mật khẩu không trùng khớp, vui lòng nhập lại")]
        public string ConfirmPassword { set; get; }

        [Display(Name = "Họ tên đầy đủ")]
        [Required(ErrorMessage = "Yêu cầu nhập tên họ tên")]
        public string Fullname { set; get; }

        [Display(Name = "Số điện thoại liên hệ")]
        [Required(ErrorMessage = "Yêu cầu nhập số điện thoại liên hệ")]
        public string Phone { set; get; }

        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Yêu cầu nhập địa chỉ")]
        public string Address { set; get; }

        [Display(Name = "Loại tài khoản")]
        public string Role { set; get; }
        //public int Status { set Status ==1; }
    }
}