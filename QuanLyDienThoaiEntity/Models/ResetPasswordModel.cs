using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyDienThoaiEntity.Models
{
	public class ResetPasswordModel
	{

		[Display(Name = "Mật khẩu mới")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Chưa nhập mật khẩu mới !")]
		[DataType(DataType.Password)]
		public string NewPassword { get; set; }

		[Display(Name = "Xác nhận mật khẩu")]
		[DataType(DataType.Password)]
		[Compare("NewPassword", ErrorMessage = "Mật khẩu xác nhận không trùng với mật khẩu mới !")]
		public string ConfirmPassword { get; set; }
		
		[Required]
		public string ResetCode { get; set; }
	}
}