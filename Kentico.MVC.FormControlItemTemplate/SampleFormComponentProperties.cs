using CMS.DataEngine;
using Kentico.Forms.Web.Mvc;

namespace $rootnamespace$
{
    public class $safeitemname$ : FormComponentProperties<string> // TODO: change string to desired output type
    {
        public $safeitemname$() : base(FieldDataType.LongText) // TODO: change FieldDataType enum value to a data type corresponding to output type of form control
        {
        }

        [DefaultValueEditingComponent($fileinputname$Component.IDENTIFIER, DefaultValue = "Hello world")]
        public override string DefaultValue { get; set; }
    }
}
