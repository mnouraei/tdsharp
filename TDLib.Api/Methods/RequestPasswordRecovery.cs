using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class RequestPasswordRecovery : Method<PasswordRecoveryInfo>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "requestPasswordRecovery";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

    }

}
