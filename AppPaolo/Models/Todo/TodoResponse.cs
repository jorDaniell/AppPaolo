using Newtonsoft.Json;
using System.Collections.Generic;

namespace AppPaolo.Models.Todo {

    public class TodoResponse {

        [JsonProperty("page")]
        public int  Page{ get; set; }

        [JsonProperty("per_page")]
        public int  PerPage{ get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("total_pages")]
        public int TtotalPages { get; set; }

        [JsonProperty("data")]
        public List<TodoModel> TodoList { get; set; }
    }
}
