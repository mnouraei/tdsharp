using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class CheckChatUsernameResult : Structure
    {

        public class CheckChatUsernameResultUsernameOccupied : CheckChatUsernameResult
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "checkChatUsernameResultUsernameOccupied";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
