using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class Video : Structure
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "video";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("has_stickers")]
        public bool HasStickers { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("supports_streaming")]
        public bool SupportsStreaming { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("thumbnail")]
        public PhotoSize Thumbnail { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("video")]
        public File Video_ { get; set; }

    }

}
