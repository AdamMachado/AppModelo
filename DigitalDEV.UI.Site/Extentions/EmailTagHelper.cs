using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace DigitalDEV.UI.Site.Extentions
{
    public class EmailTagHelper : TagHelper
    {
        public string EmailDomain { get; set; } = "desenvolvedor.io";
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() +"@" + EmailDomain;
            output.Attributes.SetAttribute("href", "Adam:" + target);
            output.Content.SetContent(target);
        }


    }
}
