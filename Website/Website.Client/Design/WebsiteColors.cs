using System.Drawing;

namespace Website.Client.Design
{
    public record WebsiteColors
    {
        //.Net colors
        public Color Background { get; set; } = Color.White;

        public Color Primary { get; set; } = Color.DarkGray;
        public Color Secondary { get; set; } = Color.Gray;

        public Color TextPrimary { get; set; } = Color.White;
        public Color TextSecondary { get; set; } = Color.Wheat;


        //Conversion to html for css and theme usage
        public string BackgroundHtml => ColorTranslator.ToHtml(Background);

        public string PrimaryHtml => ColorTranslator.ToHtml(Primary);
        public string SecondaryHtml => ColorTranslator.ToHtml(Secondary);

        public string TextPrimaryHtml => ColorTranslator.ToHtml(TextPrimary);
        public string TextSecondaryHtml => ColorTranslator.ToHtml(TextSecondary);


        //Color presets
        public static WebsiteColors DarkGreen => new WebsiteColors
        {
            Background = Color.FromArgb(25, 26, 25),

            Primary = Color.FromArgb(30, 81, 40),
            Secondary = Color.FromArgb(78, 159, 61),

            TextPrimary = Color.FromArgb(78, 159, 61),
            TextSecondary = Color.FromArgb(216, 233, 168)
        };

    }
}
