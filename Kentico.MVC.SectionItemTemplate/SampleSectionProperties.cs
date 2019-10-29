using Kentico.PageBuilder.Web.Mvc;
using Kentico.Forms.Web.Mvc;

namespace $rootnamespace$
{
    public class $safeitemname$ : ISectionProperties
    {
        // Defines a property and sets its default value
        // Assigns the default Kentico text input component, which allows users to enter
        // a string value for the property in the section's configuration dialog
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 0, Label = "Color")]
        public string Color { get; set; } = "#FFF";
    }
}
