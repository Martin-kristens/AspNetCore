using Infrastrucutre.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Infrastrucutre.Services;

public class CourseService(HttpClient http, IConfiguration configuration)
{
    private readonly HttpClient _http = http;
    private readonly IConfiguration _configuration = configuration;


    public async Task<IEnumerable<Course>> GetCoursesAsync(string category = "")
    {

        var response = await _http.GetAsync($"{_configuration["ApiUris:Courses"]}?category={category}");
        if (response.IsSuccessStatusCode)
        {
            var result = JsonConvert.DeserializeObject<CourseResult>(await response.Content.ReadAsStringAsync());
            if (result != null && result.Succeeded)
            {
                return result.Courses ??= null!;
            }
            
        }

        return null!;
    }
}