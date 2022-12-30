using System.Drawing;

namespace Website.Client.Design
{
    public record WebThemeColors
    {
        //.Net colors
        public string Background { get; set; } = "#FFFFFF";

        public string Primary { get; set; } = "#888888";
        public string Secondary { get; set; } = "#AAAAAA";
        public string Dark { get; set; } = "#444444";
        public string Light { get; set; } = "CCCCCC";

        public string TextPrimary { get; set; } = "000000";
        public string TextSecondary { get; set; } = "FF0000";
        public string TextHighlight { get; set; } = "0000FF";


        //Color presets
        public static WebThemeColors LightGreenTheme => new WebThemeColors
        {
            Background = "#D8E9A8",

            Primary = "#1E5128",
            Secondary = "#4E9F3D",
            Dark = "#191A19",
            Light = "#D8E9A8",

            TextPrimary = "#191A19",
            TextSecondary = "#1E5128",
            TextHighlight = "#D8E9A8",
        };

        public static WebThemeColors DarkTheme => new WebThemeColors
        {
            Background = "#28363C",

            Primary = "#38474E",
            Secondary = "#584D4C",
            Dark = "#222B2F",
            Light = "#45565E",

            TextPrimary = "#FFFFFF",
            TextSecondary = "#584D4C",
            TextHighlight = "#368CBB"
        };

    }
}
