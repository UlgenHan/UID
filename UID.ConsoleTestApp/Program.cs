// See https://aka.ms/new-console-template for more information
using UID.Core.Component;
using UID.Core.Generator;
using UID.Core.HTML.Tags.Sectioning;
using UID.Core.HTML.Tags.Text;

var head = new HeadElement();

var body = new BodyElement();

var ParagraphElement = new ParagraphElement();
var rawText = new RawTextElement("Bu bir denemedir");
ParagraphElement.AddChildren(rawText);

body.AddChildren(ParagraphElement);

var uiComponent = new UIComponent();
uiComponent.HeadHtmlElements.Add(head);
uiComponent.BodyHtmlElements.Add(body);
uiComponent.StyleSelectors = new List<UID.Core.CSS.CSSSelector>();
var page = uiComponent.GetPage();


var generator = new Generator();

generator.ProjectName = "Denem";
generator.GenerationPath = @"C:\MyCustomWorks\test";
generator.Pages.Add(page);
generator.Generate();
