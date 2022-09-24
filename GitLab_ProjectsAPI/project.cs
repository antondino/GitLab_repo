using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace GitLab_ProjectsAPI
{
    public class Project
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

    }
    
}



