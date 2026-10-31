using System.Net;
using homework.Models.DTOS.UserDtos;
using System.Net.Http.Json;

namespace homework.Services;

public interface IUserService
{
    Task<List<UserDto>> GetAllAsync();
    Task AddAsync(UserDto newUser);
    Task UpdateAsync(UserDto user);
    Task DeleteAsync(int id);
}

public class UserService : IUserService
{
    private readonly HttpClient _http;
    private readonly string _baseUrl = "https://jsonplaceholder.typicode.com/users";

    //constructor
    public UserService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<UserDto>> GetAllAsync()
    {
        try
        {
            return await _http.GetFromJsonAsync<List<UserDto>>(_baseUrl) ?? new();
        }
        catch (HttpRequestException ex)
        {
            throw ToFriendlyException(ex);
        }
    }

    public async Task AddAsync(UserDto newUser)
    {
        try
        {
            var response = await _http.PostAsJsonAsync(_baseUrl, newUser);
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException ex)
        {
            throw ToFriendlyException(ex);
        }
    }

    public async Task UpdateAsync(UserDto user)
    {
        try
        {
            var response = await _http.PutAsJsonAsync($"{_baseUrl}/{user.Id}", user);
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException ex)
        {
            throw ToFriendlyException(ex);
        }
    }

    public async Task DeleteAsync(int id)
    {
        try
        {
            var response = await _http.DeleteAsync($"{_baseUrl}/{id}");

            // API giả: dòng tự thêm (id > 10) trả 404 thì vẫn coi là đã xóa
            if (response.StatusCode == HttpStatusCode.NotFound)
                return;

            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException ex)
        {
            throw ToFriendlyException(ex);
        }
    }

    // Đổi lỗi HTTP thành thông báo dễ hiểu
    private static Exception ToFriendlyException(HttpRequestException ex) =>
        ex.StatusCode is not null
            ? new Exception($"Server trả về lỗi {(int)ex.StatusCode}")
            : new Exception("Không thể kết nối tới server");
}
