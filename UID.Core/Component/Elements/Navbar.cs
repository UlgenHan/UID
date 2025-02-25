

using UID.Core.CSS;
using UID.Core.CSS.CSSElements.Typography;
using UID.Core.HTML.Tags.Forms;
using UID.Core.HTML.Tags.Lists;
using UID.Core.HTML.Tags.Sectioning;
using UID.Core.HTML.Tags.Text;
using UID.Core.HTML.Tags.Text.InlineText;

namespace UID.Core.Component.Elements
{
    public class Navbar : UIComponent
    {
        // Properties to customize the Navbar
        public string LogoText { get; set; }
        public List<(string Text, string Url)> MenuItems { get; set; } = new List<(string, string)>();
        public bool ShowSearchBar { get; set; } = true;

        public Navbar() : base("nav")
        {
            // Set default CSS classes for styling
            AddClass("navbar");
        }

        //public override void Build()
        //{
        //    // Clear any previous children if needed (depends on your implementation)
        //    // Create Logo element
        //    var logo = new AElement("#", LogoText ?? "MySite");
        //    logo.AddClasses("navbar-logo");

        //    // Create Menu container
        //    var menuList = new UlElement();
        //    menuList.AddClass("navbar-menu");

        //    // Build menu items
        //    foreach (var (text, url) in MenuItems)
        //    {
        //        var listItem = new LiElement();
        //        var link = new AnchorElement(url, text);
        //        listItem.AddChild(link);
        //        menuList.AddChild(listItem);
        //    }

        //    // Add Logo and Menu to the Navbar
        //    RootElement.AddChild(logo);
        //    RootElement.AddChild(menuList);

        //    // Optionally add a search bar
        //    if (ShowSearchBar)
        //    {
        //        var searchContainer = new DivElement();
        //        searchContainer.AddClass("navbar-search");

        //        var searchForm = new FormElement();
        //        searchForm.AddClass("search-form");

        //        var searchInput = new InputElement();
        //        // You might have a constructor that accepts attributes like placeholder
        //        // For now, we'll assume adding attributes manually
        //        searchInput.AddAttribute("type", "text");
        //        searchInput.AddAttribute("placeholder", "Search...");
        //        searchInput.AddClass("search-input");

        //        var searchButton = new ButtonElement();
        //        searchButton.AddChild(new RawTextElement("Go"));
        //        searchButton.AddClass("search-button");

        //        searchForm.AddChild(searchInput);
        //        searchForm.AddChild(searchButton);
        //        searchContainer.AddChild(searchForm);

        //        RootElement.AddChild(searchContainer);
        //    }
        //}

        public override void Build()
        {
            // Create Logo element and assign CSS using CSSSelector
            var logo = new AElement("#", LogoText ?? "MySite");
            var navbarLogoCSS = new CSSSelector("navbar-logo");
            navbarLogoCSS.AddElement(new FontSizeElement("1.5rem"));
            navbarLogoCSS.AddElement(new FontWeightElement("bold"));
            logo.AddClasses(navbarLogoCSS);

            // Create Menu container and assign basic styles via CSSSelector
            var menuList = new UlElement();
            var navbarMenuCSS = new CSSSelector("navbar-menu");
            navbarMenuCSS.AddElement(new CSSElement("list-style", "none"));
            navbarMenuCSS.AddElement(new CSSElement("display", "flex"));
            navbarMenuCSS.AddElement(new CSSElement("margin", "0"));
            navbarMenuCSS.AddElement(new CSSElement("padding", "0"));
            menuList.AddClasses(navbarMenuCSS);

            // Build menu items
            foreach (var (text, url) in MenuItems)
            {
                var listItem = new LiElement();
                listItem.AddStyle(new CSSElement("margin", "0 1rem"));

                var link = new AElement(url, text);
                var menuLinkCSS = new CSSSelector("menu-link");
                menuLinkCSS.AddElement(new CSSElement("text-decoration", "none"));
                menuLinkCSS.AddElement(new CSSElement("color", "inherit"));
                menuLinkCSS.AddElement(new CSSElement("transition", "color 0.3s"));
                link.AddClasses(menuLinkCSS);

                listItem.AddChildren(link);
                menuList.AddChildren(listItem);
            }

            // Add Logo and Menu to the Navbar root element
            RootElement.AddChildren(logo);
            RootElement.AddChildren(menuList);

            // Optionally add a search bar
            if (ShowSearchBar)
            {
                var searchContainer = new DivElement();
                var navbarSearchCSS = new CSSSelector("navbar-search");
                navbarSearchCSS.AddElement(new CSSElement("display", "flex"));
                navbarSearchCSS.AddElement(new CSSElement("align-items", "center"));
                searchContainer.AddClasses(navbarSearchCSS);

                var searchForm = new FormElement();
                var searchFormCSS = new CSSSelector("search-form");
                searchFormCSS.AddElement(new CSSElement("display", "flex"));
                searchFormCSS.AddElement(new CSSElement("align-items", "center"));
                searchForm.AddClasses(searchFormCSS);

                var searchInput = new InputElement();
                searchInput.AddAttribute("type", "text");
                searchInput.AddAttribute("placeholder", "Search...");
                var searchInputCSS = new CSSSelector("search-input");
                searchInputCSS.AddElement(new CSSElement("padding", "0.25rem 0.5rem"));
                searchInputCSS.AddElement(new CSSElement("border", "none"));
                searchInputCSS.AddElement(new CSSElement("border-radius", "4px 0 0 4px"));
                searchInput.AddClasses(searchInputCSS);

                var searchButton = new ButtonElement();
                searchButton.AddChildren(new RawTextElement("Go"));
                var searchButtonCSS = new CSSSelector("search-button");
                searchButtonCSS.AddElement(new CSSElement("padding", "0.25rem 0.75rem"));
                searchButtonCSS.AddElement(new CSSElement("border", "none"));
                searchButtonCSS.AddElement(new CSSElement("border-radius", "0 4px 4px 0"));
                searchButtonCSS.AddElement(new CSSElement("background-color", "#555"));
                searchButtonCSS.AddElement(new CSSElement("color", "#fff"));
                searchButtonCSS.AddElement(new CSSElement("cursor", "pointer"));
                searchButtonCSS.AddElement(new CSSElement("transition", "background-color 0.3s"));
                searchButton.AddClasses(searchButtonCSS);

                searchForm.AddChildren(searchInput);
                searchForm.AddChildren(searchButton);
                searchContainer.AddChildren(searchForm);

                RootElement.AddChildren(searchContainer);
            }

            // Set overall Navbar container styles via inline CSS
            RootElement.AddStyle(new CSSElement("display", "flex"));
            RootElement.AddStyle(new CSSElement("align-items", "center"));
            RootElement.AddStyle(new CSSElement("justify-content", "space-between"));
            RootElement.AddStyle(new CSSElement("background-color", "#333"));
            RootElement.AddStyle(new CSSElement("padding", "0.5rem 1rem"));
            RootElement.AddStyle(new CSSElement("color", "#fff"));
        }


    }

}
