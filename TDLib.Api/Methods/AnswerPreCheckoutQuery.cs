using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class AnswerPreCheckoutQuery : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "answerPreCheckoutQuery";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter.Int64))]
        [JsonProperty("pre_checkout_query_id")]
        public Int64 PreCheckoutQueryId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

    }

}
