using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class TestUseError : Method<Error>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "testUseError";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

    }

}
