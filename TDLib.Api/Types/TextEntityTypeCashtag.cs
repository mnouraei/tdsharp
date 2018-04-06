using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TextEntityType : Structure
    {

        public class TextEntityTypeCashtag : TextEntityType
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "textEntityTypeCashtag";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
