using Imi.Project.Blazor.Constants;
using Imi.Project.Blazor.Models;
using Imi.Project.Blazor.Models.Api;
using Imi.Project.Blazor.Services.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Api
{
    public class ApiMovieService : IApiMovieService
    {
        private readonly HttpClient _httpClient;

        public ApiMovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MyConstants.JwtToken);
        }

        public async Task<List<MyMovieListItem>> ListAllMoviesAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<MyMovieListItem>>($"{MyConstants.BaseUrl}{MyConstants.MoviesUrl}");
            return result;
        }

        public async Task<MyMovieItem> GetByMovieIdAsync(Guid id)
        {
            var genres = await _httpClient.GetFromJsonAsync<List<GenreResponse>>($"{MyConstants.BaseUrl}{MyConstants.GenresUrl}");
            var languages = await _httpClient.GetFromJsonAsync<List<LanguageResponse>>($"{MyConstants.BaseUrl}{MyConstants.LanguagessUrl}");
            var directors = await _httpClient.GetFromJsonAsync<List<DirectorResponse>>($"{MyConstants.BaseUrl}{MyConstants.DirectorsUrl}");


            var result = await _httpClient.GetFromJsonAsync<MyMovieItem>($"{MyConstants.BaseUrl}{MyConstants.MoviesUrl}/{id}");

            result.Genres = genres.Select(g => new InputSelectItem { Value= g.Id.ToString(), Label= g.Name }).ToArray();
            result.Languages = languages.Select(l => new InputSelectItem { Value = l.Id.ToString(), Label = l.Name }).ToArray();
            result.Directors = directors.Select(d => new InputSelectItem { Value = d.Id.ToString(), Label = d.Name }).ToArray();
            return result;
        }

        public async Task AddMovieAsync(MyMovieItem movie)
        {
            MyMovieRequestItem movieRequest = new MyMovieRequestItem
            {
                Title = movie.Title,
                ReleaseYear = movie.ReleaseYear,
                Description = movie.Description,
                Image = movie.Image,
                GenreId = Guid.Parse(movie.GenreId),
                LanguageId = Guid.Parse(movie.LanguageId),
                DirectorId = Guid.Parse(movie.DirectorId)
            };
             await _httpClient.PostAsJsonAsync<MyMovieRequestItem>($"{MyConstants.BaseUrl}{MyConstants.MoviesUrl}", movieRequest);
        }

        public async Task UpdateMovieAsync(MyMovieItem movie)
        {
            MyMovieRequestItem movieRequest = new MyMovieRequestItem
            {
                Title = movie.Title,
                ReleaseYear = movie.ReleaseYear,
                Description = movie.Description,
                Image = movie.Image,
                GenreId = Guid.Parse(movie.GenreId),
                LanguageId = Guid.Parse(movie.LanguageId),
                DirectorId = Guid.Parse(movie.DirectorId)
            };
            await _httpClient.PutAsJsonAsync($"{MyConstants.BaseUrl}{MyConstants.MoviesUrl}", movieRequest);
        }

        public async Task DeleteMovieAsync(MyMovieListItem movie)
        {
            await _httpClient.DeleteAsync($"{MyConstants.BaseUrl}{MyConstants.MoviesUrl}/{movie.Id}");
        }

        public async Task LoginAsync()
        {
            LoginRequest user = new LoginRequest
            {
                UserName = MyConstants.PriAdminUsername,
                Password = MyConstants.PriAdminPassword
            };

            var result = await _httpClient.PostAsJsonAsync($"{MyConstants.BaseUrl}{MyConstants.UserssUrl}/login", user);
            var response = await result.Content.ReadAsStringAsync();
            var token = JsonConvert.DeserializeObject<LoginResponse>(response);

            MyConstants.JwtToken = token.JwtToken;
        }
    }
}