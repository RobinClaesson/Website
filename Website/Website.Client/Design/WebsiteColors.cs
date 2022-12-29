using System.Drawing;

namespace Website.Client.Design
{
    public record WebsiteColors
    {
        public Color Background { get; set; } = Color.White;
        public Color Text { get; set; } = Color.Black;

        public Color DarkAccent { get; set; } = Color.DarkGray;
        public Color MiddleAccent { get; set; } = Color.Gray;
        public Color LightAccent { get; set; } = Color.LightGray;

        public static WebsiteColors DarkGreen => new WebsiteColors
        {
            Background = Color.FromArgb(25, 26, 25),
            Text = Color.FromArgb(216, 233, 168),
            DarkAccent = Color.FromArgb(30, 81, 40),
            MiddleAccent = Color.FromArgb(78, 159, 61),
            LightAccent = Color.FromArgb(216, 233, 168)
        };

    }
}
