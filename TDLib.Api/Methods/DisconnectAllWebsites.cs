using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class DisconnectAllWebsites : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "disconnectAllWebsites";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

    }

}
