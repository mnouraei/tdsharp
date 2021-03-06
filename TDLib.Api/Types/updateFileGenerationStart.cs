using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public class UpdateFileGenerationStart : Update
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateFileGenerationStart";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("generation_id")]
                public Int64 GenerationId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("original_path")]
                public string OriginalPath { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("destination_path")]
                public string DestinationPath { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("conversion")]
                public string Conversion { get; set; }

        }

    }

}
