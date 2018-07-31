using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BaseProject.Intrastructure.TagHelpers
{
  
    [HtmlTargetElement("input", TagStructure = TagStructure.WithoutEndTag)]
    public class AutoComplete : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("autocomplete", "off");
        }
    }
}
