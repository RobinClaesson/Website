using System.Drawing;

namespace Website.Client.Design
{
    public record WebsiteColors
    {
        //.Net colors
        public Color Background { get; set; } = Color.White;
        public Color AccentDark { get; set; } = Color.DarkGray;
        public Color AccentMedium { get; set; } = Color.Gray;
        public Color AccentLight { get; set; } = Color.LightGray;

        //Conversion to html for css usage
        public string BackgroundHtml => ColorTranslator.ToHtml(Background);
        public string AccentDarkHtml => ColorTranslator.ToHtml(AccentDark);
        public string AccentMediumHtml => ColorTranslator.ToHtml(AccentMedium);
        public string AccentLightHtml => ColorTranslator.ToHtml(AccentLight);

        //Color presets
        public static WebsiteColors DarkGreen => new WebsiteColors
        {
            Background = Color.FromArgb(25, 26, 25),
            AccentDark = Color.FromArgb(30, 81, 40),
            AccentMedium = Color.FromArgb(78, 159, 61),
            AccentLight = Color.FromArgb(216, 233, 168)
        };

    }
}
