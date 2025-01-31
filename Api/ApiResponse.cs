using System.Text.Json;

namespace LimsUtils.Api;

public class ApiResponse
{

    public void HandleResponse<T>()
    {
        if(this?.Data != null)
        {
            var jsonString = JsonSerializer.Serialize(this.Data);
            var departementDtos = JsonSerializer.Deserialize<T>(jsonString);
            if(departementDtos != null) this.Data = departementDtos;
        }
    }

    public object? Data { get; set; }
    public Dictionary<string, object>? ViewBag { get; set; }
    public string? Message { get; set; }
    public bool IsSuccess { get; set; }
    public int StatusCode { get; set; }
}
