using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatEventAction : Structure
    {

        public class ChatEventTitleChanged : ChatEventAction
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventTitleChanged";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("old_title")]
                public string OldTitle { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_title")]
                public string NewTitle { get; set; }

        }

    }

}
