using UID.Core.Component;
using UID.Core.CSS;
using UID.Core.CSS.CSSElements.Typography;
using UID.Core.Generator;
using UID.Core.HTML;
using UID.Core.HTML.Tags.Sectioning;
using UID.Core.HTML.Tags.Text;

var htmlGen = new HTMLGenerator();
var cssGen = new CSSGenerator();

// Create a page
var page = new Page
{
    NameHtml = "index",
    NameCss = "style",
    RootElement = new HtmlDocument() // Replace with your custom element tree.
};


var roothtml = page.RootElement;

var headHtml = new HeadElement();

var bodyHtml = new BodyElement();

roothtml.AddChildren(headHtml);
roothtml.AddChildren(bodyHtml);

var paragrafItem = new HeadingElement(3);

paragrafItem.AddChildren(new RawTextElement("This is the way ahahahahah"));

var btnStyle = new CSSSelector("btn")
    .AddElement(new ColorElement("blue"));

paragrafItem.AddClasses(btnStyle);



bodyHtml.AddChildren(paragrafItem);
page.CssSelectors.Add(btnStyle);

// Create the main generator with injected generators
var generator = new Generator(htmlGen, cssGen)
{
    GenerationPath = @"D:\Console\TryWay",
    ProjectName = "MyProject",
    Pages = new List<Page> { page }
};


generator.Generate();