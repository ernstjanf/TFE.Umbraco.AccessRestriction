namespace TFE.Umbraco.AccessRestriction.Models;

public class Config
{
    public bool Disable { get; set; }

    public bool LogBlockedIP { get; set; }

    public IEnumerable<string>? ExcludePaths { get; set; }

    public IEnumerable<string>? IncludePaths { get; set; }

    public string? LocalHost { get; set; }

    public bool IsCloudflare { get; set; }

    public string? CustomHeader { get; set; }

    public IEnumerable<string>? Whitelist { get; set; }

    public IEnumerable<string>? Blacklist { get; set; }
    
    public int? HttpStatusCode { get; set; }
}
