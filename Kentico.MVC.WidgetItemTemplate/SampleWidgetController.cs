using System.Web.Mvc;
using System.Configuration;
using Kentico.PageBuilder.Web.Mvc;
using $rootnamespace$;

[assembly: RegisterWidget(nameof($rootnamespace$.$safeitemname$), typeof($safeitemname$), "$fileinputname$", Description = "", IconClass = ""]

namespace $rootnamespace$
{
    public class $safeitemname$ : WidgetController<$fileinputname$Properties>
    {
        protected I$fileinputname$Service _$fileinputname$Service;

        public $safeitemname$(I$fileinputname$Service service)
        {
            _$fileinputname$Service = service;
        }

        public virtual ActionResult Index()
        {
            var properties = GetProperties();
            // var webConfigKey = ConfigurationManager.AppSettings["AppSettingsKey"];

            var content = _$fileinputname$Service.GetContent();
        
            var model = new $fileinputname$ViewModel
            {
                Content = content,
                ConfigurationProperty = properties.ConfigurationProperty
            };

            return PartialView("Widgets/$fileinputname$/_$fileinputname$", model);
        }
    }
}
