using System.ComponentModel.DataAnnotations;

public class LanguageAndTimeSettings
{
    public int Id { get; set; }

    [Required]
    public string Language { get; set; }

    [Required]
    public string TimeZone { get; set; }

    public LanguageAndTimeSettings()
    {
        Language = "English";
        TimeZone = "UTC";
    }
}

