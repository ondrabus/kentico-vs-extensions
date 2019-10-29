using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace $rootnamespace$
{
    public class $safeitemname$ : IWidgetProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 0)]
        public string ConfigurationProperty { get; set; }
    }
}
