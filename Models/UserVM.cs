using System.ComponentModel.DataAnnotations;

public class UserVM
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







    // Điều khoản và điều kiện
    [Range(
        typeof(bool),
        "true",
        "true",
        ErrorMessage = "Bạn phải đồng ý với Điều khoản và Điều kiện."
    )]
    public bool TermsAccepted { get; set; }
}