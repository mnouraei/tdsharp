using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GetTermsOfService : Method<Text>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "getTermsOfService";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

    }

}