using System.ComponentModel.DataAnnotations;

public class NotificationSettings
{
    public int Id { get; set; }

    [Required]
    public bool ReceiveDeadlineWarnings { get; set; }

    [Required]
    public bool ReceiveMessages { get; set; }

    public NotificationSettings()
    {
        ReceiveDeadlineWarnings = false;
        ReceiveMessages = false;
    }
}
