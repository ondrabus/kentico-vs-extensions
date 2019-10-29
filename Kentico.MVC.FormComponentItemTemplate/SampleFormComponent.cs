using Kentico.Forms.Web.Mvc;
using $rootnamespace$;

[assembly: RegisterFormComponent(
    $safeitemname$.IDENTIFIER,
    typeof($safeitemname$),
    "$safeitemname$",
    IconClass = "",
    IsAvailableInFormBuilderEditor = true,
    ViewName = "FormComponents/$fileinputname$/_$safeitemname$")]

namespace $rootnamespace$
{
    public class $safeitemname$ : FormComponent<$fileinputname$Properties, string> // TODO: change string to desired output type
    {
        public const string IDENTIFIER = "$rootnamespace$.$safeitemname$";

        [BindableProperty]
        public string Value { get; set; }

        public override string GetValue()
        {
            return Value;
        }

        public override void SetValue(string value)
        {
            Value = value;
        }
    }
}
