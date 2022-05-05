using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserCom.Model.Users
{
    public class AddEventResult
    {
        [JsonProperty("created")]
        public bool Created { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
