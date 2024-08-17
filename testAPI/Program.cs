using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace testAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            getmethod();
            Console.ReadLine();
        }

        static void getmethod()
        {
            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://jsonplaceholder.typicode.com/posts");
                //do the http get to the endpoint above
                var result = client.GetAsync(endpoint).Result;
                //get the content as a string in the json variable
                var json = result.Content.ReadAsStringAsync().Result;
                Console.WriteLine(result);
                Console.WriteLine($"\n\n\n{json}");
            }
        }
        static void postmethod()
        {
            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://jsonplaceholder.typicode.com/posts");

                var newPost = new Post()
                {
                    Title = "Test",
                    Body = "Hello World",
                    UserId = 44
                };

                //var newPostJson = JsonConvert
 
            }
        }
    }


   
}
