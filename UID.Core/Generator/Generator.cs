using UID.Core.Component;

namespace UID.Core.Generator
{
    public class Generator
    {
        public string GenerationPath { get; set; }
        public string ProjectName { get; set; }
        public List<Page> Pages { get; set; } = new List<Page>();

        // Inject your generators (you can use DI if preferred)
        private readonly IHTMLGenerator _htmlGenerator;
        private readonly ICSSGenerator _cssGenerator;

        public Generator(IHTMLGenerator htmlGenerator, ICSSGenerator cssGenerator)
        {
            _htmlGenerator = htmlGenerator;
            _cssGenerator = cssGenerator;
        }

        public void Generate()
        {
            foreach (var page in Pages)
            {
                // Use HTML generator to produce HTML string
                var htmlOutput = _htmlGenerator.Generate(page.RootElement);
                var filePath = Path.Combine(GenerationPath, $"{page.NameHtml}.{page.ExtensionHtml}");
                File.WriteAllText(filePath, htmlOutput);

                // Use CSS generator to produce CSS string
                var cssOutput = _cssGenerator.Generate(page.CssSelectors);
                var filePathCss = Path.Combine(GenerationPath, $"{page.NameCss}.{page.ExtensionCss}");
                File.WriteAllText(filePathCss, cssOutput);
            }
            Console.WriteLine("Files written successfully");
        }
    }

}
