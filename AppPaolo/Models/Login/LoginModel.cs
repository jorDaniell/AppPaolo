using Newtonsoft.Json;

namespace AppPaolo.Models.Login {
    public class LoginModel {

        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; } 
    }
}
