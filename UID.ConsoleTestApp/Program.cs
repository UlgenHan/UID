using UID.Core.Component;
using UID.Core.Component.Elements;
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

var navbar = new Navbar
{
    LogoText = "My Awesome Site",
    MenuItems = new List<(string, string)>
    {
        ("Home", "#home"),
        ("About", "#about"),
        ("Products", "#products"),
        ("Contact", "#contact")
    },
    ShowSearchBar = true
};

navbar.Build();

bodyHtml.AddChildren(navbar.RootElement);

// Create the main generator with injected generators
var generator = new Generator(htmlGen, cssGen)
{
    GenerationPath = @"C:\Experiment\Generator",
    ProjectName = "MyProject",
    Pages = new List<Page> { page }
};


generator.Generate();


//Gereken SystemInformation tam Olarak buradads system 

//generator.Generate();