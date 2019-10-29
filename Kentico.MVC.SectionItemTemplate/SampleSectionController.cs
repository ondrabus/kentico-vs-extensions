using Kentico.PageBuilder.Web.Mvc;
using System.Web.Mvc;
using System.Drawing;
using $rootnamespace$;

[assembly: RegisterSection(
    "$rootnamespace$.$fileinputname$",
    typeof($safeitemname$),
    "$fileinputname$",
    Description = "",
    IconClass = "")]

namespace $rootnamespace$
{
    public class $safeitemname$ : SectionController<$fileinputname$Properties>
    {
        public virtual ActionResult Index()
        {
            // Gets the page of the Article page type containing the currently processed section
            // var article = GetPage<Article>();

            // Gets the TreeNode of the page containing the currently processed section
            // var page = GetPage();

            var properties = GetProperties();
            var color = (Color)new ColorConverter().ConvertFromString(properties.Color);

            var model = new $fileinputname$ViewModel
            {
                Color = properties.Color,
                InvertedColor = ColorTranslator.ToHtml(Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B))
            };

            return PartialView("Sections/_$fileinputname$", model);
        }
    }
}
