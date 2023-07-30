using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BooksAPITecnology.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GoogleBooksSearch.Controllers
{
    public class HomeController : Controller
    {
        private const string ApiBaseUrl = "https://www.googleapis.com/books/v1/volumes";

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return View("Index", new List<Book>());

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(ApiBaseUrl);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await httpClient.GetAsync($"?q={query}&maxResults=10");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<GoogleBooksResult>(content);

                    var books = result.Items.Select(item => new Book
                    {
                        Title = item.VolumeInfo.Title,
                        Author = item.VolumeInfo.Authors != null ? string.Join(", ", item.VolumeInfo.Authors) : "Unknown",
                        Description = item.VolumeInfo.Description
                    }).ToList();

                    return View("Index", books);
                }

                // Em caso de erro, retorne a página de pesquisa com lista vazia.
                return View("Index", new List<Book>());
            }
        }
    }

    public class GoogleBooksResult
    {
        public List<GoogleBookItem> Items { get; set; }
    }

    public class GoogleBookItem
    {
        public GoogleVolumeInfo VolumeInfo { get; set; }
    }

    public class GoogleVolumeInfo
    {
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public string Description { get; set; }
    }

}
