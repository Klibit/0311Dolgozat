using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dolgozat0311
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Tag
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("entry")]
        public string Entry { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("interest")]
        public long Interest { get; set; }

        public override string ToString()
        {
            return Fullname;
        }
    }

    public partial class Tag
    {
        public static Tag[] FromJson(string json) => JsonConvert.DeserializeObject<Tag[]>(json, Dolgozat0311.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Tag[] self) => JsonConvert.SerializeObject(self, Dolgozat0311.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            }
        };
    }
}