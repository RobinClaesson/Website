namespace Website.Client.Pages.Projects.ProblemSolvingCode
{
    public partial class Slides
    {
        List<string> imageSources = new List<string>();

        protected override void OnInitialized()
        {
            for (int i = 1; i <= 29; i++)
            {
                imageSources.Add($"\\img\\projects\\problemSolvingCode\\Presentation_page-{i}.jpg");
            }
            base.OnInitialized();
        }
    }
}
