using System.Text.Json;

namespace LimsUtils.Utility;

public class DtoHandler
{
    public static T DtoToObject<T, K>(K dto) where T : new()
    {
        T? result = Activator.CreateInstance<T>();
        string dtoAsJson = JsonSerializer.Serialize(dto);
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        result = JsonSerializer.Deserialize<T>(dtoAsJson, options);
        if(result == null)
        {
            throw new InvalidOperationException("Failed to deserialize DTO");
        }
        return result;
    }
}