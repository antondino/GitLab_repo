using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using GitLab_ProjectsAPI;




var projects = await ProcessProjects();

foreach (var project in projects)
    Console.WriteLine(project.Name);

static async Task<List<Project>> ProcessProjects()
{
    HttpClient client = new HttpClient();

    var streamTask = client.GetStreamAsync("https://gitlab.com/api/v4/users/12624965/projects");
    var projects = await JsonSerializer.DeserializeAsync<List<Project>>(await streamTask);
    return projects;
}





