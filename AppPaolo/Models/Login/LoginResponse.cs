using Newtonsoft.Json;

namespace AppPaolo.Models.Login {

    public class LoginResponse {

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public class Data {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("other_name")]
        public string OtherName { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("gender_formatted")]
        public string GenderFormatted { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
