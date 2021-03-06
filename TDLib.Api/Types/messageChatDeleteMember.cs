using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class MessageContent : Structure
    {

        public class MessageChatDeleteMember : MessageContent
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageChatDeleteMember";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public int UserId { get; set; }

        }

    }

}
