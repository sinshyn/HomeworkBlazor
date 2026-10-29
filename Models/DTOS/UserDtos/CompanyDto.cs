namespace homework.Models.DTOS.UserDtos;

using System.Text.Json.Serialization;

public class CompanyDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("catchPhrase")]
    public string CatchPhrase { get; set; } = string.Empty;

    [JsonPropertyName("bs")]
    public string Bs { get; set; } = string.Empty;
}
