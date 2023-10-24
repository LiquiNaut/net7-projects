using System.Text.Json.Serialization;

namespace net7.Controllers.Models
{
    //convert enum na string
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Clerric = 3,
    }
}