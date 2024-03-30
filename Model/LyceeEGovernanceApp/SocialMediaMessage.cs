namespace Model
{
    public class SocialMediaMessage
    {
        public string facebookProfileValidationMessage { get; set; }
        public string twitterProfileValidationMessage { get; set; }
        public string linkedinProfileValidationMessage { get; set; }
        public string instagramProfileValidationMessage { get; set; }
        public string youtubeChannelValidationMessage { get; set; }
        public string lyceeProfileValidationMessage { get; set; }

        public void ResetAll()
        {
            facebookProfileValidationMessage = string.Empty;
            twitterProfileValidationMessage = string.Empty;
            linkedinProfileValidationMessage = string.Empty;
            instagramProfileValidationMessage = string.Empty;
            youtubeChannelValidationMessage = string.Empty;
            lyceeProfileValidationMessage = string.Empty;
        }
    }
}