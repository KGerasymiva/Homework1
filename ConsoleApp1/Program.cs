using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ConsoleApp1;

namespace HttpClientSample
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }

    class Program
    {
        static HttpClient client = new HttpClient();

        static async Task<List<T>> GetProductAsync<T>(string path)
        {
            List<T> list = new List<T>();

            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                list = await response.Content.ReadAsAsync<List<T>>();
            }
            return list;
        }

        static async Task<List<UserData>> GetUsersDataAsync()
        {
            var users = await GetProductAsync<User>("users");
            var posts = await GetProductAsync<Post>("posts");
            var comments = await GetProductAsync<Comment>("comments");
            var todos = await GetProductAsync<Todo>("todos");

            var userDataList = new List<UserData>();


            var postsList = posts.GroupJoin(comments,
                p => p.Id,
                c => c.PostId,
                (p, collection) => new PostData { Post = p, Comments = collection.ToList() }).ToList();


            foreach (var user in users)
            {

                var currentUserData = new UserData
                {
                    User = user,
                    Posts = postsList.Where(post => post.Post.UserId == user.Id).ToList(),
                    Todos = todos.Where(todo => todo.UserId == user.Id).ToList()

                };

                userDataList.Add(currentUserData);

            }

            return userDataList;
        }

        public static async Task<int> GetUserComments(int id)
        {
            var result = await GetUsersDataAsync();
            foreach (var userData in result)
            {
                //userData.
            }

            return 1;
        }



        static void Main()
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://5b128555d50a5c0014ef1204.mockapi.io/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                var result = await GetUsersDataAsync();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}