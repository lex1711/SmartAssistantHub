using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Mango.Services.StrategyApi.Models.Dto
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("tag-name")]
    public class ResponseDto : TagHelper
    {
        public object? Resault { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

        }
    }
}

