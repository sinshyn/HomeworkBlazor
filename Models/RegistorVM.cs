using System.ComponentModel.DataAnnotations;

public class RegistorVM
{
    // Họ và tên
    [Required(ErrorMessage = "Họ và tên là bắt buộc.")]
    [MinLength(3, ErrorMessage = "Họ và tên phải có ít nhất 3 ký tự.")]
    public string FullName { get; set; } = string.Empty;


    // Email
    [Required(ErrorMessage = "Email là bắt buộc.")]
    [EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng email.")]
    public string Email { get; set; } = string.Empty;


    // Số điện thoại
    [Required(ErrorMessage = "Số điện thoại là bắt buộc.")]
    [RegularExpression(
        @"^\d{10,12}$",
        ErrorMessage = "Số điện thoại phải có từ 10 đến 12 chữ số."
    )]
    public string Phone { get; set; } = string.Empty;


    // Địa chỉ - Không bắt buộc
    [MinLength(5, ErrorMessage = "Địa chỉ phải có ít nhất 5 ký tự.")]
    public string? Address { get; set; }


    // Lời nhắn
    [Required(ErrorMessage = "Lời nhắn là bắt buộc.")]
    [MinLength(10, ErrorMessage = "Lời nhắn phải có ít nhất 10 ký tự.")]
    public string Message { get; set; } = string.Empty;


    // Dịch vụ
    [Required(ErrorMessage = "Vui lòng chọn một dịch vụ.")]
    public string Service { get; set; } = string.Empty;


    // Điều khoản và điều kiện
    [Range(
        typeof(bool),
        "true",
        "true",
        ErrorMessage = "Bạn phải đồng ý với Điều khoản và Điều kiện."
    )]
    public bool TermsAccepted { get; set; }
}