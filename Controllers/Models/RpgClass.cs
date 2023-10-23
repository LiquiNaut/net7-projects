using System.Text.Json.Serialization;

namespace net7.Controllers.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Clerric = 3,
    }
}