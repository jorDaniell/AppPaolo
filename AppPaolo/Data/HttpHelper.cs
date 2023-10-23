using AppPaolo.Models.Login;
using AppPaolo.Models.Todo;
using AppPaolo.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppPaolo.Data
{
    public class HttpHelper {

        private HttpClient _client;

        public HttpHelper() {
            _client = new HttpClient();
        }

        public async Task<LoginResponse> PostLoginAsync(LoginModel loginModel) {

            LoginResponse loginResponse = null;

            try {
                string json = JsonConvert.SerializeObject(loginModel);

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                response = await _client.PostAsync(Constants.LOGIN_URL, content);

                if(response.IsSuccessStatusCode) {
                    string contenido = await response.Content.ReadAsStringAsync();
                    loginResponse = JsonConvert.DeserializeObject<LoginResponse>(contenido);
                }

            } catch(Exception ex) {
                Debug.WriteLine(ex.Message);
            }

            return loginResponse;
        }

        public async Task<List<TodoModel>> GetTodoList() {

            List<TodoModel> listResponse = null;

            try {
                HttpResponseMessage response = await _client.GetAsync(Constants.LIST_TODO_URL);

                if(response.IsSuccessStatusCode) {
                    string content = await response.Content.ReadAsStringAsync();
                    TodoResponse todoResponse = JsonConvert.DeserializeObject<TodoResponse>(content);
                    listResponse = todoResponse.TodoList;
                    return listResponse;
                }

            } catch(Exception ex) {
                Debug.WriteLine(ex.Message);
            }

            return null;
        }

    }
}
