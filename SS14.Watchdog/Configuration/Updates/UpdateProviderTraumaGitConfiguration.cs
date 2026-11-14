namespace SS14.Watchdog.Configuration.Updates;

public class UpdateProviderTraumaGitConfiguration
{
    /// <summary> Git repository URL. Not to be confused with the other BaseUrl. </summary>
    public string BaseUrl { get; set; } = null!;
    /// <summary> Git repository branch. </summary>
    public string Branch { get; set; } = "master";
    /// <summary>  Switch engine for the client not bug in the wizden launcher </summary>
    public bool SwitchEngine { get; set; } = true;
}
