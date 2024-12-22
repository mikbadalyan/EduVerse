using System.ComponentModel.DataAnnotations;

public class PrivacyAndDataSettings
{
    public int Id { get; set; }

    [Required]
    public bool PrivateAccount { get; set; }

    public PrivacyAndDataSettings()
    {
        PrivateAccount = false;
    }
}

