using Newtonsoft.Json;

namespace CLient.DataContracts
{
    public class BaseDataContract
    {
        [JsonProperty("Location")]
        public LocationDataContract Location;
        public string NameOfLocation;
        public string GoogleEarthUrl;
    }
}
