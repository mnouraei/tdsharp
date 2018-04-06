using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class SearchInstalledStickerSets : Method<StickerSets>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "searchInstalledStickerSets";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("is_masks")]
        public bool IsMasks { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("limit")]
        public int Limit { get; set; }

    }

}
