using UID.Core.Component;

namespace UID.Core.Generator
{
    public class Generator
    {
        public string GenerationPath { get; set; } 

        public string ProjectName { get; set; }

        public List<Page> Pages { get; set; } = new List<Page>();
        public Generator()
        {

        }

        public void Generate()
        {
            foreach (var page in Pages)
            {
                var filePath = Path.Combine(GenerationPath, $"${page.NameHtml}.{page.ExtensionHtml}");
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(page.HtmlStringBuilder.ToString());
                }

                var filePathCss = Path.Combine(GenerationPath, $"${page.NameCss}.{page.ExtensionCss}");
                using (StreamWriter writer = new StreamWriter(filePathCss))
                {
                    writer.WriteLine(page.CssStringBuilder.ToString());
                }
            }

            Console.WriteLine("File written successflyy");
        }

    }
}
