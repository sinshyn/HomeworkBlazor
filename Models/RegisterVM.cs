using System.ComponentModel.DataAnnotations;

public class RegisterVM : UserVM
{
    // StudyMode - bắt buộc
    [Required(ErrorMessage = "Bắt buộc chọn hình thức học")]
    public string? StudyMode { get; set; }

    //khóa học
    [Required(ErrorMessage = "Vui lòng chọn khóa học.")]
    public string Course { get; set; } = string.Empty;

    //ngày bắt đầu học
    [Required(ErrorMessage = "Vui lòng chọn ngày bắt đầu học.")]
    [FutureDate(ErrorMessage = "Ngày bắt đầu học phải từ hôm nay trở đi.")]
    public DateTime? DatePick { get; set; }

    // Lời nhắn - Không bắt buộc
    [MinLength(5, ErrorMessage = "Lời nhắn phải có ít nhất 5 ký tự.")]
    public string? Notes { get; set; }
}

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext context)
    {
        if (value is DateTime date && date.Date < DateTime.Today)
        {
            return new ValidationResult(ErrorMessage ?? "Ngày phải từ hôm nay trở đi.");
        }
        return ValidationResult.Success;
    }
}
