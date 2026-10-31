using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace homework.Models.DTOS.UserDtos;

public class UserDto
{
    [JsonPropertyName("id")] //dùng khi tên trong code khác vớI JSON trả ra
    public int Id { get; set; }

    [Required(ErrorMessage = "Họ Tên là bắt buộc")]
    [MinLength(2, ErrorMessage = "Họ Tên phải có ít nhất 2 ký tự")]
    [JsonPropertyName("name")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Username là bắt buộc")]
    [JsonPropertyName("username")]
    public string Username { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email là bắt buộc")]
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]{2,}$", ErrorMessage = "Email không hợp lệ")]
    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Số điện thoại là bắt buộc")]
    [RegularExpression(@"^(0|\+84)(3|5|7|8|9)\d{8}$", ErrorMessage = "Số điện thoại không hợp lệ")]
    [JsonPropertyName("phone")]
    public string Phone { get; set; } = string.Empty;

    [Required(ErrorMessage = "Website là bắt buộc")]
    [JsonPropertyName("website")]
    public string Website { get; set; } = string.Empty;

    // [Required(ErrorMessage = "Địa chỉ là bắt buộc")]
    // [JsonPropertyName("address")]
    // public AddressDto Address { get; set; } = new();

    // [Required(ErrorMessage = "Công ty là bắt buộc")]
    // [JsonPropertyName("company")]
    // public CompanyDto Company { get; set; } = new();
}
