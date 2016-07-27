﻿using Newtonsoft.Json;
using System.IO;

namespace Discord.API.Rest
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class ModifyCurrentUserParams
    {
        [JsonProperty("username")]
        internal Optional<string> _username;
        public string Username { set { _username = value; } }

        [JsonProperty("avatar")]
        internal Optional<Image> _avatar;
        public Stream Avatar { set { _avatar = new Image(value); } }
    }
}
