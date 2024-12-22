public class AccountSettings
{
    public int Id { get; set; }
    public string? Bio { get; set; }
    public string? PhoneNumber { get; set; }
    public string? EmailAddress { get; set; }
    public string? EducationalInstitution { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? SocialLinks { get; set; }

    public AccountSettings()
    {
        Bio = "No bio available";
        PhoneNumber = "No phone number available";
        EmailAddress = "No email address available";
        EducationalInstitution = "No educational institution available";
        Country = "No country available";
        City = "No city available";
        DateOfBirth = DateTime.MinValue;
        SocialLinks = "No social links available";
    }
}
