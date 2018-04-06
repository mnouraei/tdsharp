using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class MessageContent : Structure
    {

        public class MessageVideoNote : MessageContent
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageVideoNote";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("video_note")]
                public VideoNote VideoNote { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_viewed")]
                public bool IsViewed { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_secret")]
                public bool IsSecret { get; set; }

        }

    }

}
