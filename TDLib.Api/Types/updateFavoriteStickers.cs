using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public class UpdateFavoriteStickers : Update
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateFavoriteStickers";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker_ids")]
                public int[] StickerIds { get; set; }

        }

    }

}
