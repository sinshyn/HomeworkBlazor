using System.ComponentModel.DataAnnotations;

public class ContactVM : UserVM
{
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
}
