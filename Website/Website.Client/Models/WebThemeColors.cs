namespace Website.Client.Models
{
    public record WebThemeColors
    {
        public string ThemeName { get; set; } = "Dark";

        public string Background { get; set; } = "#28363C";

        public string Primary { get; set; } = "#38474E";
        public string Secondary { get; set; } = "#584D4C";
        public string Dark { get; set; } = "#222B2F";
        public string Light { get; set; } = "45565E";

        public string TextPrimary { get; set; } = "FFFFFF";
        public string TextSecondary { get; set; } = "584D4C";
        public string TextInfo { get; set; } = "368CBB";
    }
}
