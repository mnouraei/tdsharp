using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class CheckChatInviteLink : Method<ChatInviteLinkInfo>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "checkChatInviteLink";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("invite_link")]
        public string InviteLink { get; set; }

    }

}
